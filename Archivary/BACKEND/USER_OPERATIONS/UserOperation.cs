using Archivary.BACKEND.OBJECTS;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Archivary.BACKEND.USER_OPERATIONS
{
    public class UserOperation
    {

        static string CONNECTION_STRING = "Server=localhost;Database=archivary;User ID=root;Password=;";

        #region ENUM
        public enum UserLevel
        {
            Admin = 4,
            Employee = 3,
            Teacher = 2,
            Student = 1
        }
        public enum StudentInfo
        {
            LastName = 0,
            FirstName = 1,
            MiddleName = 2,
            Email = 3,
            Address = 4,
            ContactNum = 5,
            Department = 6,
            YearLevel = 7,
            Section = 8,
            ImagePath = 9
        }
        public enum TeacherInfo
        {
            LastName = 0,
            FirstName = 1,
            MiddleName = 2,
            Email = 3,
            Address = 4,
            ContactNum = 5,
            Department = 6,
            ImagePath = 7
        }
        #endregion

        #region OPERATIONS
        //PASSWORD RELATED METHODS
        public static string HashPassword(string password)
        {
            //Hash the password with a random salt and a work factor of 10
            return BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt(10));
        }
        public static bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            //Verify the entered password against the hashed password
            return BCrypt.Net.BCrypt.Verify(enteredPassword, hashedPassword);
        }

        //FOR INPUT VALIDATION
        public static bool IsValidEmail(string email)
        {
            //Define a regular expression pattern for a basic email validation
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            //Use Regex.IsMatch to check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }

        //FOR EXTRACTING INFORMATION IN THE DATABASE
        private static string[] GetUserByEmail(string email)
        {
            string[] result = new string[10];
            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                //Define the SQL query
                string query = "SELECT Id, FirstName, LastName, MiddleName, Email, Address, Contact_number, " +
                    "image_path, user_level, status FROM users WHERE email = @Email";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    //Add parameters to the query
                    command.Parameters.AddWithValue("@Email", email);

                    //Execute the query
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        //Check if a user was found with the given email
                        if (reader.Read())
                        {
                            result[0] = reader.GetInt32(0).ToString();
                            for (int i = 1; i <= result.Length - 1; i++)
                            {
                                if (i == 8) result[8] = reader.GetInt32(8).ToString(); //For User Level
                                else result[i] = reader.GetString(i); //Other info
                            }
                        }
                        else
                        {
                            Console.WriteLine("User not found");
                        }
                    }
                }
            }
            return result;
        }
        private static string[] GetAdminOrEmployeeByUserid(int id, int userLevel)
        {
            string[] result = new string[2];
            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                //Define the SQL query
                string query = "SELECT password, employee_id " +
                    "FROM employees WHERE user_id = @ID";

                if (userLevel == (int)UserLevel.Admin)
                {
                    query = "SELECT password, admin_id " +
                    "FROM admin WHERE user_id = @ID";
                }

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    //Add parameters to the query
                    command.Parameters.AddWithValue("@ID", id);

                    //Execute the query
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        //Check if a user was found with the given email
                        if (reader.Read())
                        {
                            result[0] = reader.GetString(0);
                            result[1] = reader.GetString(1);
                        }
                    }
                }
            }
            return result;
        }
        public static ArrayList GetAllEmployees()
        {
            ArrayList employeesList = new ArrayList();

            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = "SELECT users.id, FirstName, LastName, MiddleName, Email, Address, " +
                               "Contact_number, image_path, user_level, status, employee_id, " +
                               "security_question, question_answer " +
                               "FROM users JOIN employees ON users.id = employees.user_id " +
                               "ORDER BY LastName";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee(
                                reader["employee_id"].ToString(),
                                Convert.ToInt32(reader["id"]),
                                reader["FirstName"].ToString(),
                                reader["LastName"].ToString(),
                                reader["MiddleName"].ToString(),
                                reader["Email"].ToString(),
                                reader["Address"].ToString(),
                                reader["Contact_number"].ToString(),
                                reader["image_path"].ToString(),
                                reader["status"].ToString()
                            );
                            employeesList.Add(employee);
                        }
                    }
                }
            }

            return employeesList;
        }
        public static ArrayList GetAllStudents()
        {
            ArrayList studentsList = new ArrayList();

            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = "SELECT users.id, FirstName, LastName, MiddleName, Email, Address, " +
                               "Contact_number, image_path, user_level, status, " +
                               "student_id, department, year_level, section " +
                               "FROM users JOIN students ON users.id = students.user_id " +
                               "ORDER BY LastName";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming 'student_id' is a varchar field
                            Student student = new Student(
                                reader["student_id"].ToString(),
                                Convert.ToInt32(reader["id"]),
                                reader["FirstName"].ToString(),
                                reader["LastName"].ToString(),
                                reader["MiddleName"].ToString(),
                                reader["Email"].ToString(),
                                reader["department"].ToString(),
                                Convert.ToInt32(reader["year_level"]),
                                reader["section"].ToString(),
                                reader["Address"].ToString(),
                                reader["Contact_number"].ToString(),
                                reader["image_path"].ToString(),
                                reader["status"].ToString()
                            );

                            studentsList.Add(student);
                        }
                    }
                }
            }

            return studentsList;
        }

        public static ArrayList GetAllTeachers()
        {
            ArrayList teachersList = new ArrayList();

            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = "SELECT users.id, FirstName, LastName, MiddleName, Email, Address, " +
                               "Contact_number, image_path, user_level, status, teacher_id, " +
                               "department " +
                               "FROM users JOIN teachers ON users.id = teachers.user_id " +
                               "ORDER BY LastName";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Teacher teacher = new Teacher(
                                reader["teacher_id"].ToString(),
                                Convert.ToInt32(reader["id"]),
                                reader["FirstName"].ToString(),
                                reader["LastName"].ToString(),
                                reader["MiddleName"].ToString(),
                                reader["Email"].ToString(),
                                reader["department"].ToString(),
                                reader["Address"].ToString(),
                                reader["Contact_number"].ToString(),
                                reader["image_path"].ToString(),
                                reader["status"].ToString()
                            );
                            teachersList.Add(teacher);
                        }
                    }
                }
            }

            return teachersList;
        }
        public static DataTable GetAllUsersDataTable()
        {
            DataTable usersTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = "SELECT users.id, FirstName, LastName, MiddleName, " +
                               "user_level, status, " +
                               "employee_id, " +
                               "student_id, " +
                               "teacher_id " +
                               "FROM users " +
                               "LEFT JOIN employees ON users.id = employees.user_id " +
                               "LEFT JOIN students ON users.id = students.user_id " +
                               "LEFT JOIN teachers ON users.id = teachers.user_id " +
                               "ORDER BY LastName";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(usersTable);
                }
            }

            return usersTable;
        }


        //USER CREATION IN THE APP - LOGIN
        public static object Login(string email, string password)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) 
            {
                return null;
            }
            Object user = null;

            try
            {
                //Search User by email to get all info
                string[] userInfo = GetUserByEmail(email);
                int userLevel = int.Parse(userInfo[8]);

                //Return immediately if the email does not belong to an employee or admin
                if (userLevel == (int)UserLevel.Teacher || userLevel == (int)UserLevel.Student)
                {
                    //Add aditional actions to error if needed
                    return user;
                }

                //Extract info
                int userId = int.Parse(userInfo[0]);
                string userFirstName = userInfo[1];
                string userLastName = userInfo[2];
                string userMiddleName = userInfo[3];
                string userEmail = userInfo[4];
                string userAddress = userInfo[5];
                string userContactNum = userInfo[6];
                string userImage = userInfo[7];
                string userStatus = userInfo[9];

                //Get password and admin or employee ID
                string[] additionalInfo = GetAdminOrEmployeeByUserid(userId, userLevel);
                string hashedPass = additionalInfo[0];
                string ID = additionalInfo[1];

                // Verify pass
                bool passVerified = VerifyPassword(password, hashedPass);

                // Create object if pass matches
                if (passVerified && userStatus == "ACTIVE")
                {
                    if (userLevel == (int)UserLevel.Admin)
                    {
                        Console.WriteLine("Admin successful login");
                        user = new Admin(ID, userId, userFirstName, userLastName, userMiddleName, userEmail, userAddress, userContactNum, userImage, userStatus);
                    }
                    else if (userLevel == (int)UserLevel.Employee)
                    {
                        Console.WriteLine("Employee successful login");
                        user = new Employee(ID, userId, userFirstName, userLastName, userMiddleName, userEmail, userAddress, userContactNum, userImage, userStatus);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception using a logging library
                // Handle the exception as needed
                Console.WriteLine($"Exception during login: {ex.Message}");
                return null;
            }

            return user;
        }
        #endregion
    }
}
