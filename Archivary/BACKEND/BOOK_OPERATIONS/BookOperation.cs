using Archivary.BACKEND.OBJECTS;
using Archivary.Properties;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using OfficeOpenXml;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static Archivary.BACKEND.USER_OPERATIONS.UserOperation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Archivary.BACKEND.BOOK_OPERATIONS
{
    public class BookOperation
    {

        public enum BookInfo
        {
            ISBN = 0,
            Title = 1,
            Category = 2,
            Genre = 3,
            Author = 4,
            Publisher = 5,
            Copyright = 6,
            Aisle = 7,
            Shelf = 8,
            ImagePath = 9,
        }

        #region Sorting methods
        public static void SortInfoBaseOnSequence(int[] sequence, string[] colValues)
        {
            //Insertion sort
            for (int i = 1; i < sequence.Length; ++i)
            {
                int tempt = sequence[i];
                string tempt2 = colValues[i];
                int j = i - 1;

                while (j >= 0 && sequence[j] > tempt)
                {
                    sequence[j + 1] = sequence[j];
                    colValues[j + 1] = colValues[j];
                    j--;
                }
                sequence[j + 1] = tempt;
                colValues[j + 1] = tempt2;
            }
        }

        #endregion

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
                string query = "SELECT * FROM books WHERE status = @status and category != 'ACADEMIC' ORDER BY title ASC";

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

        public static List<Book> LoadReservedBooksOfUserFromDatabase(int borrowerId)
        {
            List<Book> bookList = new List<Book>();
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "SELECT books.* FROM reserved_books JOIN books ON reserved_books.book_id = books.id WHERE reserved_books.borrower_id = @Id and reserved_books.is_borrowed = false and reserved_books.reserved_at < NOW()";

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

        public static List<Book> ShowAllBorrowedBooks()
        {
            List<Book> bookList = new List<Book>();
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "SELECT * from books where status = 'BORROWED'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
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
                return bookList;
            }
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

        public static void BorrowReserveBook(string table, List<Book> bookList, HashSet<string> ISBNs, int userId, int librarianID)
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

                            insertCommand.CommandText = $"INSERT INTO {table} (book_id, borrower_id, {columnOne}, {columnTwo}, librarian_id) VALUES (@BookId, @UserId, @ColumnOneValue, false, @LibrarianId)";

                            insertCommand.Parameters.AddWithValue("@BookId", book.BookId);
                            insertCommand.Parameters.AddWithValue("@UserId", userId);
                            insertCommand.Parameters.AddWithValue("@ColumnOneValue", DateTime.Now);
                            insertCommand.Parameters.AddWithValue("@LibrarianId", librarianID);

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

        private static void BorrowBook(Book book, int borrowerId, int librarianId)
        {
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "INSERT INTO borrowed_books (book_id, borrower_id, borrowed_at, is_returned, librarian_id) VALUES (@book, @id, @time, false, @librarian)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@book", book.BookId);
                    command.Parameters.AddWithValue("@id", borrowerId);
                    command.Parameters.AddWithValue("@time", DateTime.Now);
                    command.Parameters.AddWithValue("@librarian", librarianId);
                    command.ExecuteNonQuery();
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
                string reserved = type.Equals("borrowed_books") ? "AND is_returned = false" : "AND is_borrowed = false";
                string query = $"SELECT COUNT(*) FROM {type} WHERE borrower_id = @Id {reserved}";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);

                    object result = command.ExecuteScalar();
                    Console.WriteLine($"query: {query}\noutput: {result}");
                    return (result != null) ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public static void SetReservedBookToBorrowed(Book book, int borrowerId, int librarianId)
        {
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "UPDATE reserved_books SET is_borrowed = true WHERE book_id = @id and borrower_id = @borrower_id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", book.BookId);
                    command.Parameters.AddWithValue("@borrower_id", borrowerId);
                    command.ExecuteScalar();
                    BorrowBook(book, borrowerId, librarianId);
                }
            }
        }

        public static void SetBorrowedBookToReturned(Book book, int borrowerId, int librarianId)
        {
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "UPDATE borrowed_books SET is_returned = true WHERE book_id = @id and borrower_id = @borrower";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", book.BookId);
                    command.Parameters.AddWithValue("@borrower", borrowerId);
                    command.ExecuteScalar();
                    SetBorrowedBookToAvailable(book);
                    InsertReturnedBookToTable(book, borrowerId, librarianId);
                }
            }
        }

        private static void SetBorrowedBookToAvailable(Book book)
        {
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "UPDATE books SET status = 'AVAILABLE' WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", book.BookId);
                    command.ExecuteScalar();
                }
            }
        }

        private static void InsertReturnedBookToTable(Book book, int borrowerId, int librarianId)
        {
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "INSERT INTO returned_books (book_id, borrower_id, return_at, librarian_id) VALUES (@book, @borrower, @time, @user)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@book", book.BookId);
                    command.Parameters.AddWithValue("@borrower", borrowerId);
                    command.Parameters.AddWithValue("@time", DateTime.Now);
                    command.Parameters.AddWithValue("@user", librarianId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Book> ShowBorrowedBooks(int borrowerId)
        {
            List<Book> bookList = new List<Book>();
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "SELECT books.* FROM borrowed_books JOIN books ON borrowed_books.book_id = books.id WHERE borrowed_books.is_returned = false and borrowed_books.borrower_id = @Id ORDER BY books.title ASC;";

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

        public static List<string> IdentifyOverdueOrNotBooks(int borrowerId)
        {
            List<string> status = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "SELECT CASE WHEN TIMESTAMPDIFF(DAY, borrowed_books.borrowed_at, CURRENT_TIMESTAMP) > settings.borrowing_duration THEN 'Overdue' ELSE 'Not Overdue' END AS status FROM borrowed_books JOIN books ON borrowed_books.book_id = books.id JOIN settings ON 1=1 WHERE borrowed_books.is_returned = false and borrowed_books.borrower_id = @id ORDER BY books.title ASC";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", borrowerId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            status.Add(reader.GetString("status"));
                        }
                    }
                }
                return status;
            }
        }

        public static List<DateTime> GetDateFromBorrowedBooks(int borrowerId)
        {
            List<DateTime> dates = new List<DateTime>();
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "SELECT borrowed_books.borrowed_at as date FROM borrowed_books JOIN books ON borrowed_books.book_id = books.id WHERE borrowed_books.borrower_id = @id ORDER BY books.title ASC";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", borrowerId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dates.Add(reader.GetDateTime("date"));
                        }
                    }
                }
            }
            return dates;
        }

        public static DateTime GetDateFromSpecificBorrowedBooks(int borrowerId, int bookId)
        {
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "SELECT borrowed_books.borrowed_at as date FROM borrowed_books JOIN books ON borrowed_books.book_id = books.id WHERE borrowed_books.borrower_id = @id and borrowed_books.book_id = @book and borrowed_books.is_returned = false";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", borrowerId);
                    command.Parameters.AddWithValue("@book", bookId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return reader.GetDateTime("date");
                        }
                    }
                }
                return DateTime.Now;
            }
        }

        public static bool CheckIfExistingUnsettledBorrowedBooks(int borrowerId)
        {
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = "SELECT COUNT(*) from borrowed_books where is_returned = false and borrower_id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", borrowerId);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public static void AddBook(string author, string genre, string isbn, string category, string title, string copyright,
            string publisher, int aisle, int shelf, string bookImage = "NO_IMAGE", string status = "AVAILABLE")
        {
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                try
                {
                    //Open a connection to database
                    connection.Open();
                    Console.WriteLine("Connected to the database.");

                    //Prepare query 
                    string insertQuery = "INSERT INTO books(" +
                        "author, genre, isbn, category, title, copyright, publisher, status, aisle, shelf, book_img_path) " +
                        "VALUES(@author, @genre, @isbn, @category, @title, @copyright, @publisher, @status, @aisle, @shelf, @book_img_path)";



                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        //Add parameters to the command
                        command.Parameters.AddWithValue("@author", author);
                        command.Parameters.AddWithValue("@genre", genre);
                        command.Parameters.AddWithValue("@isbn", isbn);
                        command.Parameters.AddWithValue("@category", category);
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@copyright", copyright);
                        command.Parameters.AddWithValue("@publisher", publisher);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@aisle", aisle);
                        command.Parameters.AddWithValue("@shelf", shelf);
                        command.Parameters.AddWithValue("@book_img_path", bookImage);

                        //Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        //Check if operation was successful
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Operation successful. {rowsAffected} rows affected.");
                        }
                        else
                        {
                            Console.WriteLine("No rows affected. Something might be wrong in inserting employees.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally { connection.Close(); }
            }
        }
        public static List<string> AddBookByExcel(string fileLocation, string workSheetLocation, int startRow)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; //Indicates to the dependency that this is for non-commercial use

            List<string> errors = new List<string>();

            using (var package = new ExcelPackage(new FileInfo(fileLocation)))
            {
                if (package != null)
                {
                    var worksheet = package.Workbook.Worksheets[workSheetLocation];

                    //Check if the worksheet exists
                    if (worksheet != null)
                    {
                        // Get the actual row count with data
                        int actualRowCount = 0;
                        for (int row = startRow - 1; row <= worksheet.Dimension.End.Row; row++)
                        {
                            var rowHasData = worksheet.Cells[row, worksheet.Dimension.Start.Column, row, worksheet.Dimension.End.Column]
                                .Any(cell => cell.Value != null);

                            if (rowHasData)
                            {
                                actualRowCount++;
                            }
                        }

                        if (actualRowCount == 0 || actualRowCount == 1)
                        {
                            errors.Add("There are no information inside the excell file");
                            return errors;
                        }

                        int actualColumnCount = 0;
                        for (int col = worksheet.Dimension.Start.Column; col <= worksheet.Dimension.End.Column; col++)
                        {
                            var columnHasData = worksheet.Cells
                                .Any(cell => cell.Start.Column == col && cell.Value != null);

                            if (columnHasData)
                            {
                                actualColumnCount++;
                            }
                        }

                        // Check if the number of columns is as expected
                        if (actualColumnCount != 10)
                        {
                            errors.Add($"Expected {10} columns, but found {actualColumnCount} columns.");
                            return errors;
                        }

                        for (int row = 1; row <= (startRow - 2) + actualRowCount; row++)
                        {
                            if (row < startRow) continue; //skips the rows above the header
                            string[] colValues = new string[10]; //Store info here
                            //Iterate through columns
                            for (int col = worksheet.Dimension.Start.Column; col <= actualColumnCount; col++)
                            {
                                //Take cell info of value
                                var cellValue = worksheet.Cells[row, col].Value;

                                //Check if the cell value is int before inserting in the array
                                if (cellValue != null)
                                {
                                    // Check if the cell value is of type double
                                    if (cellValue is double doubleValue)
                                    {
                                        // Handle double value (convert to string or format as needed)
                                        colValues[col - 1] = doubleValue.ToString();
                                    }
                                    else
                                    {
                                        // Handle other types (string, date, etc.)
                                        colValues[col - 1] = cellValue.ToString().Trim();
                                    }
                                }
                                else
                                {
                                    // Handle null cell value if needed
                                    colValues[col - 1] = string.Empty;
                                }
                            }
                            //If start row is greater than 1, check the header to identify which info is in the column
                            //If start row is equal to 1 it will identify the information by default order
                            if (startRow > 1)
                            {
                                IdentificationResult result = IdentifyBookColumnInfoSequence(worksheet, startRow);
                                if (!result.Success)
                                {
                                    errors.Add(result.ErrorMessage);
                                    return errors;
                                }
                                //Check if header is appropriate and describes the required book info
                                if (result.Success)
                                {
                                    //Sort info
                                    SortInfoBaseOnSequence(result.Sequence, colValues);
                                }
                                //Check if all infos provided is valid
                            }
                            var validateResult = CheckBookInfoFromExcel(colValues);
                            if (validateResult.isValid)
                            {
                                if (string.IsNullOrEmpty(colValues[(int)BookInfo.ImagePath]) ||
                                    colValues[(int)BookInfo.ImagePath].ToUpper().Trim() == "NO_IMAGE" ||
                                    colValues[(int)BookInfo.ImagePath].ToUpper().Trim() == "NO IMAGE" ||
                                    colValues[(int)BookInfo.ImagePath].ToUpper().Trim() == "NO-IMAGE" ||
                                    colValues[(int)BookInfo.ImagePath].ToUpper().Trim() == "NOIMAGE" ||
                                    colValues[(int)BookInfo.ImagePath].ToUpper().Trim() == "N/A")
                                {
                                    AddBook(
                                        colValues[(int)BookInfo.Author],
                                        colValues[(int)BookInfo.Genre],
                                        colValues[(int)BookInfo.ISBN],
                                        colValues[(int)BookInfo.Category],
                                        colValues[(int)BookInfo.Title],
                                        colValues[(int)BookInfo.Copyright],
                                        colValues[(int)BookInfo.Publisher],
                                        int.Parse(colValues[(int)BookInfo.Aisle]),
                                        int.Parse(colValues[(int)BookInfo.Shelf])
                                        );
                                }
                                else
                                {
                                    AddBook(
                                        colValues[(int)BookInfo.Author],
                                        colValues[(int)BookInfo.Genre],
                                        colValues[(int)BookInfo.ISBN],
                                        colValues[(int)BookInfo.Category],
                                        colValues[(int)BookInfo.Title],
                                        colValues[(int)BookInfo.Copyright],
                                        colValues[(int)BookInfo.Publisher],
                                        int.Parse(colValues[(int)BookInfo.Aisle]),
                                        int.Parse(colValues[(int)BookInfo.Shelf]),
                                        colValues[(int)BookInfo.ImagePath]
                                        );
                                }
                            }
                            else
                            {
                                errors.Add($"Row Number: {row} {validateResult.errorMessage}");
                            }
                        }

                    }
                    else
                    {
                        errors.Add($"Worksheet {workSheetLocation} does not exist");
                    }
                }
                else
                {
                    errors.Add($"File: {fileLocation} does not exist");
                }
            }
            return errors;
        }

        private static IdentificationResult IdentifyBookColumnInfoSequence(ExcelWorksheet worksheet, int startRow)
        {
            //Check if the start row is greater than 1
            //if start row is equal to 1 it means that there are no header because worksheet is 1 indexed
            if (startRow < 2) return IdentificationResult.CreateError("Start Row is Less Than 2");

            int headerLocation = startRow - 1; //move one cell up assuming that the header is directly above the first row

            //Initialize array
            int[] sequence = new int[10];

            // Track encountered headers
            HashSet<string> encounteredHeaders = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //Loop to fill the array
            for (int row = headerLocation; row == headerLocation; row++)
            {
                for (int col = worksheet.Dimension.Start.Column; col <= sequence.Length; col++)
                {
                    //Take cell value
                    var cellValue = worksheet.Cells[headerLocation, col].Value;

                    //Check first if cell is null
                    if (cellValue != null)
                    {
                        // Check if the cells are all string
                        if (cellValue is double doubleValue || cellValue is int intValue || cellValue is float floatValue)
                        {
                            return IdentificationResult.CreateError("Cell Value is a type of number or decimal");
                        }

                        // Check if the header is unique
                        string headerName = cellValue.ToString().Trim().ToUpper();
                        if (!encounteredHeaders.Add(headerName))
                        {
                            return IdentificationResult.CreateError($"Duplicate header found '{headerName}' in column {col}");
                        }

                        //Fill the array with values based from cell header name
                        if (cellValue.ToString().Trim().ToUpper() == "ISBN")
                        {
                            sequence[col - 1] = (int)BookInfo.ISBN;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "TITLE")
                        {
                            sequence[col - 1] = (int)BookInfo.Title;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "CATEGORY")
                        {
                            sequence[col - 1] = (int)BookInfo.Category;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "GENRE")
                        {
                            sequence[col - 1] = (int)BookInfo.Genre;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "AUTHOR" ||
                            cellValue.ToString().Trim().ToUpper() == "AUTHOR NAME" ||
                            cellValue.ToString().Trim().ToUpper() == "AUTHOR_NAME" ||
                            cellValue.ToString().Trim().ToUpper() == "AUTHOR-NAME")
                        {
                            sequence[col - 1] = (int)BookInfo.Author;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "PUBLISHER")
                        {
                            sequence[col - 1] = (int)BookInfo.Publisher;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "COPYRIGHT")
                        {
                            sequence[col - 1] = (int)BookInfo.Copyright;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "AISLE")
                        {
                            sequence[col - 1] = (int)BookInfo.Aisle;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "SHELF")
                        {
                            sequence[col - 1] = (int)BookInfo.Shelf;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "IMAGE PATH" ||
                                cellValue.ToString().Trim().ToUpper() == "IMAGE_PATH" ||
                                cellValue.ToString().Trim().ToUpper() == "IMAGE-PATH" ||
                                cellValue.ToString().Trim().ToUpper() == "IMAGEPATH" ||
                                cellValue.ToString().Trim().ToUpper() == "IMAGE")
                        {
                            sequence[col - 1] = (int)BookInfo.ImagePath;
                        }
                        else return IdentificationResult.CreateError($"Column {headerName} in your header is not in the right format or does not correctly identify the column");
                    }
                    else return IdentificationResult.CreateError($"Column {col} in your header is empty");
                }
            }
            return IdentificationResult.CreateSuccess(sequence);
        }
        public static (bool isValid, string errorMessage) CheckBookInfoFromExcel(string[] bookInfos)
        {
            //Checks isbn
            if (!IsValidIsbn(bookInfos[(int)BookInfo.ISBN]))
            {
                return (false, "Invalid ISBN");
            }
            //Checks aisle and shelf 
            if (!IsValidInteger(bookInfos[(int)BookInfo.Aisle]))
            {
                return (false, "Invalid aisle location");
            }
            if (!IsValidInteger(bookInfos[(int)BookInfo.Shelf]))
            {
                return (false, "Invalid shelf location");
            }
            if (!IsValidCategory(bookInfos[(int)(BookInfo.Category)]))
            {
                return (false, "Invalid Category");
            }

            var categoryToGenreValidation = IsGenreAppropriate(bookInfos[(int)BookInfo.Genre], bookInfos[(int)BookInfo.Category]);
            if (!categoryToGenreValidation.isValid1)
            {
                return (false, categoryToGenreValidation.ErrorMessage1);
            }

            if (string.IsNullOrEmpty(bookInfos[(int)BookInfo.ImagePath]) ||
                !(bookInfos[(int)BookInfo.ImagePath].ToUpper().Trim() == "NO_IMAGE" ||
                bookInfos[(int)BookInfo.ImagePath].ToUpper().Trim() == "NO IMAGE" ||
                bookInfos[(int)BookInfo.ImagePath].ToUpper().Trim() == "NO-IMAGE" ||
                bookInfos[(int)BookInfo.ImagePath].ToUpper().Trim() == "NOIMAGE" ||
                bookInfos[(int)BookInfo.ImagePath].ToUpper().Trim() == "N/A"))
            {
                if (!DoesFileExistAndIsImage(bookInfos[(int)BookInfo.ImagePath]))
                {
                    return (false, "Invalid image file or file does not exist");
                }
            }
            string[] headerNames = { "ISBN", "Title", "Category", "Genre",
                "Author", "Publisher", "Copyright", "Aisle", "Shelf", "IMAGE PATH" };

            for (int i = 0; i < bookInfos.Length; i++)
            {
                //skip iteration
                if (i == (int)BookInfo.ISBN || i == (int)BookInfo.Aisle || i == (int)BookInfo.Shelf || i == (int)BookInfo.Category) continue;
                //Checks other infos
                if (bookInfos[i] == null || string.IsNullOrEmpty(bookInfos[i]))
                {
                    return (false, $"Entered Book info is null in column {headerNames[i]}");
                }
            }
            return (true, null); // No errors
        }
        public static bool IsValidIsbn(string input)
        {
            return !string.IsNullOrEmpty(input) &&
                   input.All(char.IsDigit) &&
                   (input.Length == 10 || input.Length == 13);
        }
        public static bool IsValidInteger(string input)
        {
            // Try to parse the input as an integer, and check if it's greater than zero
            if (int.TryParse(input, out int parsedValue))
            {
                return parsedValue > 0;
            }

            return false;
        }
        public static bool IsValidStatus(string input)
        {
            if (!string.IsNullOrEmpty(input) &&
                (input.ToUpper().Trim() == "AVAILABLE" ||
                input.ToUpper().Trim() == "UNAVAILABLE" ||
                input.ToUpper().Trim() == "RESERVED"))
            {
                return true;
            }
            return false;
        }
        public static bool IsValidCategory(string input)
        {
            if (!string.IsNullOrEmpty(input) &&
                (input.ToUpper().Trim() == "FICTION" ||
                input.ToUpper().Trim() == "NON-FICTION" ||
                input.ToUpper().Trim() == "NON FICTION" ||
                input.ToUpper().Trim() == "NON_FICTION" ||
                input.ToUpper().Trim() == "NONFICTION" ||
                input.ToUpper().Trim() == "ACADEMIC"))
            {
                return true;
            }
            return false;
        }
        public static (bool isValid1, string ErrorMessage1) IsGenreAppropriate(string genre, string category)
        {
            List<string> academicGenres = new List<string> { "Science and nature", "Philosophy", "History", "English", "Filipino", "Mathematics" };
            List<string> nonfictionGenres = new List<string> { "Autobiography", "Biography", "Memoir", "Food and cooking", "Health and Wellness", "Self help", "Technology", "Travel and Exploration" };
            List<string> fictionGenres = new List<string> { "Fantasy", "Mystery", "Thriller", "Romance", "Horror", "Children's Literature", "Science Fiction", "Historical Fiction", "Young Adult",
                                                        "Action", "Adventure", "Supernatural", "Comedy/Satire", "psychological fiction", "apocalyptic/post-apocalyptic" };

            if (category == "Academic" && academicGenres.Contains(genre))
            {
                return (true, "Genre is appropriate for Academic category");
            }
            else if (category == "Nonfiction" && nonfictionGenres.Contains(genre))
            {
                return (true, "Genre is appropriate for Nonfiction category");
            }
            else if (category == "Fiction" && fictionGenres.Contains(genre))
            {
                return (true, "Genre is appropriate for Fiction category");
            }
            else
            {
                return (false, "Genre is not appropriate for the specified category please check the settings for the list of genres");
            }
        }

        public static List<BookReportsInfo> SetInfoFromBorrowedReports()
        {
            List<BookReportsInfo> reports = new List<BookReportsInfo>();
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = @"SELECT
                                    st.student_id AS user_id,
                                    b.isbn AS book_id,
                                    b.title,
                                    b.author,
                                    bb.borrowed_at AS obtained_date,
                                    ADDDATE(bb.borrowed_at, INTERVAL s.borrowing_duration DAY) AS return_date,
                                    CASE
                                        WHEN bb.is_returned = 1 THEN 'Returned'
                                        WHEN CURRENT_TIMESTAMP() > ADDDATE(bb.borrowed_at, INTERVAL s.borrowing_duration DAY) THEN 'Overdue'
                                        ELSE 'Not Overdue'
                                    END AS status
                                FROM
                                    books b
                                    JOIN borrowed_books bb ON b.id = bb.book_id
                                    JOIN students st ON bb.borrower_id = st.user_id  -- Use user_id from students table
                                    JOIN settings s ON s.id = 1

                                UNION

                                SELECT
                                    t.teacher_id AS user_id,
                                    b.isbn AS book_id,
                                    b.title,
                                    b.author,
                                    bb.borrowed_at AS obtained_date,
                                    ADDDATE(bb.borrowed_at, INTERVAL s.borrowing_duration DAY) AS return_date,
                                    CASE
                                        WHEN bb.is_returned = 1 THEN 'Returned'
                                        WHEN CURRENT_TIMESTAMP() > ADDDATE(bb.borrowed_at, INTERVAL s.borrowing_duration DAY) THEN 'Overdue'
                                        ELSE 'Not Overdue'
                                    END AS status
                                FROM
                                    books b
                                    JOIN borrowed_books bb ON b.id = bb.book_id
                                    JOIN teachers t ON bb.borrower_id = t.user_id  -- Use user_id from teachers table
                                    JOIN settings s ON s.id = 1
                                ORDER BY return_date DESC;
                                ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a new BookReportsInfo object for each row
                            BookReportsInfo report = new BookReportsInfo
                            {
                                userId = reader.GetString("user_id"),
                                isbn = reader.GetString("book_id"), // Assuming "id" is the appropriate column name
                                title = reader.GetString("title"),
                                author = reader.GetString("author"),
                                obtainedDate = reader.GetDateTime("obtained_date"),
                                dueDate = reader.GetDateTime("return_date"),
                                status = reader.GetString("status")
                            };

                            // Add the object to the list
                            reports.Add(report);
                        }
                    }
                }
                return reports;
            }
        }

        public static List<BookReportsInfo> SetInfoFromReservedReports()
        {
            List<BookReportsInfo> reports = new List<BookReportsInfo>();
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();
                string query = @"SELECT
                                    st.student_id AS user_id,
                                    b.isbn AS book_id,
                                    b.title,
                                    b.author,
                                    rb.reserved_at AS obtained_date,
                                    ADDDATE(rb.reserved_at, INTERVAL s.reserve_duration DAY) AS return_date,
                                    CASE
                                        WHEN rb.is_borrowed = 1 AND CURRENT_TIMESTAMP() < ADDDATE(rb.reserved_at, INTERVAL s.reserve_duration DAY) THEN 'Borrowed'
		                                WHEN rb.is_borrowed = 0 AND CURRENT_TIMESTAMP() > ADDDATE(rb.reserved_at, INTERVAL s.reserve_duration DAY) THEN 'Available'
		                                ELSE 'Reserved'
                                    END AS status
                                FROM
                                    books b
                                    JOIN reserved_books rb ON b.id = rb.book_id
                                    JOIN students st ON rb.borrower_id = st.user_id
                                    JOIN settings s ON s.id = 1

                                UNION

                                SELECT
                                    t.teacher_id AS user_id,
                                    b.isbn AS book_id,
                                    b.title,
                                    b.author,
                                    rb.reserved_at AS obtained_date,
                                    ADDDATE(rb.reserved_at, INTERVAL s.reserve_duration DAY) AS return_date,
                                    CASE
                                        WHEN rb.is_borrowed = 1 AND CURRENT_TIMESTAMP() < ADDDATE(rb.reserved_at, INTERVAL s.reserve_duration DAY) THEN 'Borrowed'
		                                WHEN rb.is_borrowed = 0 AND CURRENT_TIMESTAMP() > ADDDATE(rb.reserved_at, INTERVAL s.reserve_duration DAY) THEN 'Available'
		                                ELSE 'Reserved'
                                    END AS status
                                FROM
                                    books b
                                    JOIN reserved_books rb ON b.id = rb.book_id
                                    JOIN teachers t ON rb.borrower_id = t.user_id
                                    JOIN settings s ON s.id = 1
                                ORDER BY return_date desc";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a new BookReportsInfo object for each row
                            BookReportsInfo report = new BookReportsInfo
                            {
                                userId = reader.GetString("user_id"),
                                isbn = reader.GetString("book_id"), // Assuming "id" is the appropriate column name
                                title = reader.GetString("title"),
                                author = reader.GetString("author"),
                                obtainedDate = reader.GetDateTime("obtained_date"),
                                dueDate = reader.GetDateTime("return_date"),
                                status = reader.GetString("status")
                            };

                            // Add the object to the list
                            reports.Add(report);
                        }
                    }
                }
                return reports;
            }
        }

        private static int IdentifyReservedBorrowedBookQueue(int bookId)
        {
            int result = 0;

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();

                string query = @"
                                SELECT COUNT(*) 
                                FROM reserved_books 
                                WHERE book_id = @bookId 
                                AND reserved_at > NOW()
                                AND is_borrowed = 0;
                            ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bookId", bookId);

                    // ExecuteScalar can return null, so use Convert.ToInt32 to handle it
                    object scalarResult = command.ExecuteScalar();

                    // Check for null before casting
                    if (scalarResult != null)
                    {
                        result = Convert.ToInt32(scalarResult);
                    }
                }
            }

            return result < 1 ? 1 : result;
        }

        private static DateTime GetDueDateOfPreviousRecordedBook(int bookId)
        {
            int queue = IdentifyReservedBorrowedBookQueue(bookId);

            if (queue > 1)
            {
                // If the queue is not empty, use reserved_books
                return GetDueDateOfPreviousReservedBook(bookId);
            }
            else
            {
                // If the queue is empty, use borrowed_books
                return GetDueDateOfPreviousBorrowedBook(bookId);
            }
        }

        private static DateTime GetDueDateOfPreviousReservedBook(int bookId)
        {
            DateTime date = DateTime.MinValue;
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();

                string query = @"
                    SELECT max(reserved_at)
                    FROM reserved_books 
                    WHERE book_id = @bookId 
                    AND is_borrowed = 0;
                ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bookId", bookId);
                    date = (DateTime)command.ExecuteScalar();
                }
            }
            return date;
        }

        private static DateTime GetDueDateOfPreviousBorrowedBook(int bookId)
        {
            DateTime date = DateTime.MinValue;
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();

                string query = @"
                    SELECT max(borrowed_at)
                    FROM borrowed_books 
                    WHERE book_id = @bookId 
                    AND is_returned = 0;
                ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bookId", bookId);
                    date = (DateTime)command.ExecuteScalar();
                }
            }
            return date;
        }

        public static DateTime GetDateToGetQueuedReservedBorrowedBook(int bookId, Setting settings)
        {
            //get date to get (previous due date + reserved duration * queue),  // jan 1 + 3 * 1 = jan 4
            // if queue > 1, (previous due date + borrowing duration * (queue-1) + reserved duration * queue) // jan 1 + 2 + 3 * 2 = jan 9
            // if queue = 3, jan 1 + 2 * 3-1 + 3 * 3 = jan 1 + 4 + 9 = jan 14
            DateTime previousDueDate = GetDueDateOfPreviousRecordedBook(bookId);
            int queue = IdentifyReservedBorrowedBookQueue(bookId);
            int reserve = settings.reservedDuration;
            int borrow = settings.borrowingDuration;

            return queue > 1 ? previousDueDate.AddDays(borrow * (queue-1) + reserve * queue) : previousDueDate.AddDays(reserve * queue);
        }

        public static DateTime GetDueDateOfQueuedReservedBorrowedBook(int bookId, Setting settings)
        {
            //get duedate (date to get + borrowing duration) // jan 4 + 2 = jan 6 
            DateTime dateToGet = GetDateToGetQueuedReservedBorrowedBook(bookId, settings);
            int duration = settings.borrowingDuration;
            return dateToGet.AddDays(duration);
        }

        public static void ReserveBorrowedBook(int borrowerId, int bookId, int librarianId, DateTime dateToGet, DateTime dueDate)
        {
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();

                string query = @"
                                    INSERT INTO reserved_books (book_id, borrower_id, reserved_at, librarian_id)
                                    SELECT 
                                        @bookId as book_id,
                                        @borrowerId as borrower_id,
                                        @dateToGet AS reserved_at,
                                        @librarianId AS librarian_id
                                    FROM 
                                        borrowed_books
                                    JOIN 
                                        settings ON 1=1
                                    WHERE book_id = @bookId;
                                ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bookId", bookId);
                    command.Parameters.AddWithValue("@borrowerId", borrowerId);
                    command.Parameters.AddWithValue("@librarianId", librarianId);
                    command.Parameters.AddWithValue("@dateToGet", dateToGet);
                    command.Parameters.AddWithValue("@dueDate", dueDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool CheckIfBorrowedBookIsSameUser(int borrowerId, int bookId)
        {
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM borrowed_books WHERE borrower_id = @borrowerId AND book_id = @bookId and is_returned = false;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@borrowerId", borrowerId);
                    command.Parameters.AddWithValue("@bookId", bookId);

                    // ExecuteScalar is used when you expect a single value result, like a COUNT query
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Return true if the count is greater than 0, indicating the book is borrowed by the user
                    return count > 0;
                }
            }
        }
    }
}

