using Archivary.BACKEND.OBJECTS;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.COMMON_OPERATIONS
{
    public class CommonOperation
    {
        static string CONNECTION_STRING = "Server=localhost;Database=archivary;User ID=root;Password=;";

        public static Setting GetSettingsFromDatabase()
        {
            Setting settings = null;

            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
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
                                Convert.ToInt32(reader["reserve_limit"]),
                                Convert.ToInt32(reader["borrowing_duration"])
                            );
                        }
                    }
                }
            }
            return settings;
        }

        public static bool UpdateSettings(int borrowingCapacity, int reserveLimit, int borrowingDuration)
        {
            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = "UPDATE settings " +
                               "SET borrowing_capacity = @BorrowingCapacity, " +
                               "reserve_limit = @ReserveLimit, " +
                               "borrowing_duration = @BorrowingDuration " +
                               "WHERE id = 1"; // Assuming there is only one row in the settings table

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BorrowingCapacity", borrowingCapacity);
                    command.Parameters.AddWithValue("@ReserveLimit", reserveLimit);
                    command.Parameters.AddWithValue("@BorrowingDuration", borrowingDuration);

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

    }
}
