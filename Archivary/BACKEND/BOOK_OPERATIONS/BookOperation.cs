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
        public static Dictionary<int, Book> LoadBooksFromDatabase()
        {
            Dictionary<int, Book> booksDictionary = new Dictionary<int, Book>();

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();

                string query = "SELECT * FROM books ORDER BY title ASC";

                using (MySqlCommand command = new MySqlCommand(query, connection))
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

                        booksDictionary.Add(id, book);
                    }
                }
            }
            return booksDictionary;
        }
    }
}

