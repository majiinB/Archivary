using Archivary.BACKEND.OBJECTS;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Archivary.BACKEND.BOOK_OPERATIONS
{
    public class BookOperation
    {
        public static List<Book> LoadBooksFromDatabase(string categoryFilter)
        {
            List<Book> booksList = new List<Book>();

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();

                string query;
                if (categoryFilter.ToUpper() == "ALL")
                {
                    query = "SELECT * FROM books ORDER BY title ASC";
                }
                else
                {
                    query = "SELECT * FROM books WHERE category = @category ORDER BY title ASC";
                }

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (categoryFilter.ToUpper() != "All")
                    {
                        command.Parameters.AddWithValue("@category", categoryFilter);
                    }

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string title = reader.GetString("title");
                            string genre = reader.GetString("genre");
                            string author = reader.GetString("author");
                            string isbn = reader.GetString("isbn");
                            string category = reader.GetString("category");
                            string copyright = reader.GetString("copyright");
                            string publisher = reader.GetString("publisher");
                            string status = reader.GetString("status");
                            int aisle = reader.GetInt32("aisle");
                            int shelf = reader.GetInt32("shelf");
                            string imagePath = reader.GetString("book_img_path");

                            Book book = new Book(id, title, genre, author, isbn, category, copyright,
                                publisher, status, aisle, shelf, imagePath);

                            booksList.Add(book);
                        }
                    }
                }
            }
            return booksList;
        }

        public static List<Book> LoadAvailableBooksFromDatabase(string statusFilter)
        {
            List<Book> booksList = new List<Book>();

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "SELECT * FROM books WHERE status = @status ORDER BY title ASC";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@status", statusFilter);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string title = reader.GetString("title");
                            string genre = reader.GetString("genre");
                            string author = reader.GetString("author");
                            string isbn = reader.GetString("isbn");
                            string category = reader.GetString("category");
                            string copyright = reader.GetString("copyright");
                            string publisher = reader.GetString("publisher");
                            string status = reader.GetString("status");
                            int aisle = reader.GetInt32("aisle");
                            int shelf = reader.GetInt32("shelf");
                            string imagePath = reader.GetString("book_img_path");

                            Book book = new Book(id, title, genre, author, isbn, category, copyright,
                                publisher, status, aisle, shelf, imagePath);

                            booksList.Add(book);
                        }
                    }
                }
            }
            return booksList;
        }

        public static List<Book> SearchBooks(List<Book> books, string searchTerm)
        {
            // If the search term is empty, return all books
            if (string.IsNullOrWhiteSpace(searchTerm) || searchTerm == "Search Book")
            {
                return books;
            }

            // Convert the search term to lowercase for case-insensitive search
            string searchTermLower = searchTerm.ToLower();

            // Use LINQ to perform the search
            List<Book> searchResults = books
                .Where(book =>
                    book.BookTitle.ToLower().Contains(searchTermLower.ToLower()) ||
                    book.BookAuthor.ToLower().Contains(searchTermLower.ToLower()) ||
                    book.BookGenre.ToLower().Contains(searchTermLower.ToLower()) ||
                    book.BookISBN.ToLower().Contains(searchTermLower.ToLower()) ||
                    book.BookCategory.ToLower().Contains(searchTermLower.ToLower()) ||
                    book.BookPublisher.ToLower().Contains(searchTermLower.ToLower()) ||
                    book.BookStatus.ToLower().Contains(searchTermLower.ToLower()) ||
                    book.BookAisle.ToString().ToLower().Contains(searchTermLower.ToLower()) ||
                    book.BookShelf.ToString().ToLower().Contains(searchTermLower.ToLower())
                )
                .ToList();

            return searchResults;
        }

        public static void BorrowReserveBook(string table, List<Book> bookList, HashSet<string> ISBNs, int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                conn.Open();

                using (MySqlTransaction transaction = conn.BeginTransaction())
                try
                {
                    foreach (Book book in bookList)
                    if (ISBNs.Contains(book.BookISBN))
                        using (MySqlCommand insertCommand = conn.CreateCommand())
                        {
                            insertCommand.Transaction = transaction;

                            string columnOne = (table == "borrowed_books") ? "borrowed_at" : "reserved_at";
                            string columnTwo = (table == "borrowed_books") ? "is_returned" : "is_borrowed";

                            insertCommand.CommandText = $"INSERT INTO {table} (book_id, borrower_id, {columnOne}, {columnTwo}) VALUES (@BookId, @UserId, @ColumnOneValue, false)";

                            insertCommand.Parameters.AddWithValue("@BookId", book.BookId);
                            insertCommand.Parameters.AddWithValue("@UserId", userId);
                            insertCommand.Parameters.AddWithValue("@ColumnOneValue", DateTime.Now);

                            insertCommand.ExecuteNonQuery();

                            string status = (table == "borrowed_books") ? "BORROWED" : "RESERVED";
                            UpdateBorrowReserveBook(transaction, status, book);
                        }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
        }

        public static void UpdateBorrowReserveBook(MySqlTransaction transaction, string status, Book book)
        {
            using (MySqlCommand updateCommand = transaction.Connection.CreateCommand())
            {
                updateCommand.Transaction = transaction;
                updateCommand.CommandText = "UPDATE books SET status = @Status WHERE id = @BookId";

                updateCommand.Parameters.AddWithValue("@Status", status);
                updateCommand.Parameters.AddWithValue("@BookId", book.BookId);

                updateCommand.ExecuteNonQuery();
            }
        }

        public static int CheckCountOfExistingBorrowedReservedBooks(int userId, string type)
        {
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = $"SELECT COUNT(*) FROM {type} WHERE borrower_id = @Id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);

                    object result = command.ExecuteScalar();
                    return (result != null) ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public static List<Book> ShowBorrowedReservedBooks(int borrowerId)
        {
            List<Book> bookList = new List<Book>();
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "SELECT books.* FROM borrowed_books JOIN books ON borrowed_books.book_id = books.id WHERE borrowed_books.borrower_id = @Id UNION SELECT books.* FROM reserved_books JOIN books ON reserved_books.book_id = books.id WHERE reserved_books.borrower_id = @Id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", borrowerId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string title = reader.GetString("title");
                            string genre = reader.GetString("genre");
                            string author = reader.GetString("author");
                            string isbn = reader.GetString("isbn");
                            string category = reader.GetString("category");
                            string copyright = reader.GetString("copyright");
                            string publisher = reader.GetString("publisher");
                            string status = reader.GetString("status");
                            int aisle = reader.GetInt32("aisle");
                            int shelf = reader.GetInt32("shelf");
                            string imagePath = reader.GetString("book_img_path");

                            Book book = new Book(id, title, genre, author, isbn, category, copyright,
                                publisher, status, aisle, shelf, imagePath);

                            bookList.Add(book);
                        }
                    }
                }
            }
            return bookList;
        }

    }
}

