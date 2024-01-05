using Archivary.BACKEND.OBJECTS;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary.BACKEND.COMMON_OPERATIONS
{
    public class CommonOperation
    { 
        #region Arrays
        public static string[] MONTHS = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
        public static string[] CATEGORIES = { "Academic", "Fiction", "Nonfiction" };
        public static string[] GENRES = { "Science and nature", "Philosophy", "History", "English", "Filipino", "Mathematics", //Academic genres
        "Autobiography","Biograpy", "Memoir", "Food and cooking", "Health and Wellness", "Self help", "Technology", "Travel and Exploration", // Nonfiction genres
        "Fantasy", "Mystery", "Thriller", "Romance", "Horror", "Children's Literature", "Science Fiction", " Historical Fiction", "Young Adult", //Fiction genres
        "Action", "Adventure", "Supernatural", "Comedy/Satire", "psychological fiction", "apocalyptic/post-apocalyptic" };
        public static string[] TimeFormatsArray = { "yyyy-MM-dd" , "1/1/0001 12:00:00 AM", "Not Returned" };
        #endregion

        #region Enum
        
        #endregion
        public enum TimeFormats
        {
           YearMontDate = 0,
           DateTimeMin = 1,
           IfNotReturnedStatus = 2
        }

        #region Settings
        public static Setting GetSettingsFromDatabase()
        {
            Setting settings = null;

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();

                string query = "SELECT * FROM settings WHERE id = 1";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            settings = new Setting
                            (
                                Convert.ToInt32(reader["id"]),
                                Convert.ToInt32(reader["borrowing_capacity"]),
                                Convert.ToInt32(reader["borrowing_capacity_teacher"]),
                                Convert.ToInt32(reader["reserve_limit"]),
                                Convert.ToInt32(reader["borrowing_duration"])
                            );
                        }
                    }
                }
            }
            return settings;
        }
        public static bool UpdateSettings(int borrowingCapacity, int borrowingCapacityTeacher, int reserveLimit, int borrowingDuration)
        {
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();

                string query = "UPDATE settings " +
                               "SET borrowing_capacity = @BorrowingCapacity, " +
                               "reserve_limit = @ReserveLimit, " +
                               "borrowing_duration = @BorrowingDuration, " +
                               "borrowing_capacity_teacher = @BorrowingCapacityTeacher " +
                               "WHERE id = 1"; // Assuming there is only one row in the settings table

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BorrowingCapacity", borrowingCapacity);
                    command.Parameters.AddWithValue("@ReserveLimit", reserveLimit);
                    command.Parameters.AddWithValue("@BorrowingDuration", borrowingDuration);
                    command.Parameters.AddWithValue("@BorrowingCapacityTeacher", borrowingCapacityTeacher);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // If at least one row is affected, return true
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error updating data: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        #endregion

        #region Reports
        public static async Task<int> GetUserCountAsync()
        {
            int userCount = 0;

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                await connection.OpenAsync();

                string query = "SELECT COUNT(*) as userCount FROM users WHERE status = 'ACTIVE' AND (user_level = 1 OR user_level = 2);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    object result = await command.ExecuteScalarAsync();

                    if (result != null)
                    {
                        userCount = Convert.ToInt32(result);
                    }
                }
            }
            return userCount;
        }
        public static async Task<int> GetBookCountAsync()
        {
            int bookCount = 0;

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                await connection.OpenAsync();

                string query = "SELECT COUNT(*) as bookCount FROM books;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    object result = await command.ExecuteScalarAsync();

                    if (result != null)
                    {
                        bookCount = Convert.ToInt32(result);
                    }
                }
            }

            return bookCount;
        }

        //Methods to retrieve counts for books borrowed, reserved, returned for the current month
        public static async Task<int> GetBorrowedBooksCountForCurrentMonthAsync()
        {
            int borrowedBooksCount = 0;

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                await connection.OpenAsync();

                // Get the current month and year
                DateTime currentDate = DateTime.Now;
                int currentMonth = currentDate.Month;
                int currentYear = currentDate.Year;

                string query = "SELECT COUNT(*) as borrowedBooksCount " +
                               "FROM borrowed_books " +
                               "WHERE MONTH(borrowed_at) = @currentMonth AND YEAR(borrowed_at) = @currentYear";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@currentMonth", currentMonth);
                    command.Parameters.AddWithValue("@currentYear", currentYear);

                    object result = await command.ExecuteScalarAsync();

                    if (result != null)
                    {
                        borrowedBooksCount = Convert.ToInt32(result);
                    }
                }
            }

            return borrowedBooksCount;
        }
        public static async Task<int> GetReservedBooksCountForCurrentMonthAsync()
        {
            int reservedBooksCount = 0;

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                await connection.OpenAsync();

                // Get the current month and year
                DateTime currentDate = DateTime.Now;
                int currentMonth = currentDate.Month;
                int currentYear = currentDate.Year;

                string query = "SELECT COUNT(*) as reservedBooksCount " +
                               "FROM reserved_books " +
                               "WHERE MONTH(reserved_at) = @currentMonth AND YEAR(reserved_at) = @currentYear";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@currentMonth", currentMonth);
                    command.Parameters.AddWithValue("@currentYear", currentYear);

                    object result = await command.ExecuteScalarAsync();

                    if (result != null)
                    {
                        reservedBooksCount = Convert.ToInt32(result);
                    }
                }
            }

            return reservedBooksCount;
        }
        public static async Task<int> GetReturnedBooksCountForCurrentMonthAsync()
        {
            int returnedBooksCount = 0;

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                await connection.OpenAsync();

                // Get the current month and year
                DateTime currentDate = DateTime.Now;
                int currentMonth = currentDate.Month;
                int currentYear = currentDate.Year;

                string query = "SELECT COUNT(*) as returnedBooksCount " +
                               "FROM returned_books " +
                               "WHERE MONTH(return_at) = @currentMonth AND YEAR(return_at) = @currentYear";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@currentMonth", currentMonth);
                    command.Parameters.AddWithValue("@currentYear", currentYear);

                    object result = await command.ExecuteScalarAsync();

                    if (result != null)
                    {
                        returnedBooksCount = Convert.ToInt32(result);
                    }
                }
            }

            return returnedBooksCount;
        }

        public static async Task<int> GetBorrowedBooksCountForMonthAsync(int targetMonth)
        {
            int borrowedBooksCount = 0;

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                await connection.OpenAsync();

                DateTime currentDate = DateTime.Now;
                int currentYear = currentDate.Year;

                string query = "SELECT COUNT(*) as borrowedBooksCount " +
                               "FROM borrowed_books " +
                               "WHERE MONTH(borrowed_at) = @targetMonth AND YEAR(borrowed_at) = @targetYear";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@targetMonth", targetMonth);
                    command.Parameters.AddWithValue("@targetYear", currentYear);

                    object result = await command.ExecuteScalarAsync();

                    if (result != null)
                    {
                        borrowedBooksCount = Convert.ToInt32(result);
                    }
                }
            }

            return borrowedBooksCount;
        }
        public static async Task<int> GetReservedBooksCountForMonthAsync(int targetMonth)
        {
            int reservedBooksCount = 0;

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                await connection.OpenAsync();

                DateTime currentDate = DateTime.Now;
                int currentYear = currentDate.Year;

                string query = "SELECT COUNT(*) as reservedBooksCount " +
                               "FROM reserved_books " +
                               "WHERE MONTH(reserved_at) = @targetMonth AND YEAR(reserved_at) = @targetYear";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@targetMonth", targetMonth);
                    command.Parameters.AddWithValue("@targetYear", currentYear);

                    object result = await command.ExecuteScalarAsync();

                    if (result != null)
                    {
                        reservedBooksCount = Convert.ToInt32(result);
                    }
                }
            }

            return reservedBooksCount;
        }
        public static async Task<int> GetReturnedBooksCountForMonthAsync(int targetMonth)
        {
            int returnedBooksCount = 0;

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                await connection.OpenAsync();

                DateTime currentDate = DateTime.Now;
                int currentYear = currentDate.Year;

                string query = "SELECT COUNT(*) as returnedBooksCount " +
                               "FROM returned_books " +
                               "WHERE MONTH(return_at) = @targetMonth AND YEAR(return_at) = @targetYear";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@targetMonth", targetMonth);
                    command.Parameters.AddWithValue("@targetYear", currentYear);

                    object result = await command.ExecuteScalarAsync();

                    if (result != null)
                    {
                        returnedBooksCount = Convert.ToInt32(result);
                    }
                }
            }

            return returnedBooksCount;
        }
        public static async Task<int> CountBooksByCategoryAsync(string category)
        {
            int bookCount = 0;

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                await connection.OpenAsync();

                string query = "SELECT COUNT(*) FROM books WHERE category = @category";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@category", category);

                    object result = await command.ExecuteScalarAsync();

                    if (result != null)
                    {
                        bookCount = Convert.ToInt32(result);
                    }
                }
            }

            return bookCount;
        }
        public static async Task<int> CountBooksByGenreAsync(string genre)
        {
            int bookCount = 0;

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                await connection.OpenAsync();

                string query = "SELECT COUNT(*) FROM books WHERE genre = @genre";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@genre", genre);

                    object result = await command.ExecuteScalarAsync();

                    if (result != null)
                    {
                        bookCount = Convert.ToInt32(result);
                    }
                }
            }

            return bookCount;
        }

        //Other operations
        public static string ConcatenateList(List<string> inputList)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string element in inputList)
            {
                stringBuilder.AppendLine(element);
            }

            return stringBuilder.ToString();
        }
        #endregion

    }
}
