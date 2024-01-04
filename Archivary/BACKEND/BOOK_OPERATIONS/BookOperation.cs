using Archivary.BACKEND.OBJECTS;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.BOOK_OPERATIONS
{
    public class BookOperation
    {
        static string CONNECTION_STRING = "Server=localhost;Database=archivary;User ID=root;Password=;";
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



    }
}

