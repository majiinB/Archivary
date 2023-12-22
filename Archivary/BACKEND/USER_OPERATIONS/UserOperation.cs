using Archivary.BACKEND.OBJECTS;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

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
        public static string[] IsUserInputValid(string firstName, string lastName, string middleName, string email, string address, string contactNum,
            string imagePath = "No_image", string department = "No_department", string yearLevel = "No_yearLevel", string section = "No_section", string password = "No_password",
            string securityQuestion = "No_security_quesion", string securityAnswer = "No_security_question")
        {
            string[] errorMessage = new string[2];
            if (string.IsNullOrEmpty(firstName))
            {
                errorMessage[0] = "Invalid First Name";
                errorMessage[1] = "First name can't be empty";
                return errorMessage;
            }
            if (string.IsNullOrEmpty(lastName))
            {
                errorMessage[0] = "Invalid Last Name";
                errorMessage[1] = "Last name can't be empty";
                return errorMessage;
            }
            if (string.IsNullOrEmpty(middleName))
            {
                errorMessage[0] = "Invalid Middle Name";
                errorMessage[1] = "Middle name can't be empty";
                return errorMessage;
            }
            if (string.IsNullOrEmpty(email))
            {
                errorMessage[0] = "Invalid Email";
                errorMessage[1] = "Email can't be empty";
                return errorMessage;
            }
            if (IsEmailExisting(email))
            {
                errorMessage[0] = "Invalid Email";
                errorMessage[1] = "Email already exists";
                return errorMessage;
            }
            if (!IsValidEmail(email))
            {
                errorMessage[0] = "Invalid Email";
                errorMessage[1] = "Email must be in the proper format e.g example@gmail.com";
                return errorMessage;
            }
            if (string.IsNullOrEmpty(address) || address.Length < 10)
            {
                errorMessage[0] = "Invalid Address";
                errorMessage[1] = "Please enter a valid address";
                return errorMessage;
            }
            if (!IsValidContactNumber(contactNum))
            {
                errorMessage[0] = "Invalid Contact Number";
                errorMessage[1] = "Please enter a valid contact number";
                return errorMessage;
            }
            if (!DoesFileExistAndIsImage(imagePath))
            {
                if (!(imagePath == "No_image"))
                {
                    errorMessage[0] = "Image Path Not Found";
                    errorMessage[1] = "Please check the image file path and try again";
                    return errorMessage;
                }
            }
            if (string.IsNullOrEmpty(department) || department.Length < 2)
            {
                if (!(department == "No_department"))
                {
                    errorMessage[0] = "Invalid Input for Department";
                    errorMessage[1] = "Department cannot be empty and must contain atleast three letters";
                    return errorMessage;
                }
            }
            if (string.IsNullOrEmpty(section) || section.Length < 2)
            {
                if (!(department == "No_section"))
                {
                    errorMessage[0] = "Invalid Input for Section";
                    errorMessage[1] = "Section cannot be empty and must contain atleast three letters";
                    return errorMessage;
                }
            }
            if (!IsValidInteger(yearLevel) && int.TryParse(yearLevel, out int parsedYearLevel) && parsedYearLevel > 0 && parsedYearLevel < 7)
            {
                if (!(yearLevel == "No_yearLevel"))
                {
                    errorMessage[0] = "Invalid Year Level";
                    errorMessage[1] = "Year level must be numeric and ranges form 1-6";
                    return errorMessage;
                }
            }
            if (string.IsNullOrEmpty(password) || password.Length < 7)
            {
                if (!(department == "No_password"))
                {
                    errorMessage[0] = "Invalid Input for Password";
                    errorMessage[1] = "Password cannot be empty and password must be atleast 8 characters long";
                    return errorMessage;
                }
            }
            if (string.IsNullOrEmpty(securityQuestion))
            {
                if (!(securityQuestion == "No_security_question"))
                {
                    errorMessage[0] = "Invalid Security Question";
                    errorMessage[1] = "Security quesion cannot be empty";
                    return errorMessage;
                }
            }
            if (string.IsNullOrEmpty(securityAnswer))
            {
                if (!(securityAnswer == "No_security_answer"))
                {
                    errorMessage[0] = "Invalid Security Answer";
                    errorMessage[1] = "Security answer cannot be empty";
                    return errorMessage;
                }
            }

            return new string[0];
        }
        public static bool IsValidContactNumber(string contactNumber)
        {
            //Check if the string is not null or empty
            if (string.IsNullOrEmpty(contactNumber)) return false;

            //Check if the length is 11 digits and starts with "09"
            if (contactNumber.Length == 11 && contactNumber.StartsWith("09"))
            {
                //Check if all characters are numeric
                foreach (char digit in contactNumber)
                {
                    if (!char.IsDigit(digit)) return false;
                }
                return true;
            }
            return false;
        }
        public static bool IsValidEmail(string email)
        {
            //Define a regular expression pattern for a basic email validation
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            //Use Regex.IsMatch to check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
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
        public static bool IsEmailExisting(string email)
        {
            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM users WHERE Email = @Email";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        //ExecuteScalar is used because we only need the count
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        //If count is greater than 0, the email exists
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false; // Handle the error as needed
                }
            }
        }
        public static bool DoesFileExistAndIsImage(string filePath)
        {
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                return false;
            }

            // Check if the file extension is either JPEG or PNG
            string extension = Path.GetExtension(filePath);
            if (string.Equals(extension, ".jpeg", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(extension, ".jpg", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(extension, ".png", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }
        private static int[] IdentifyStudentColumnInfoSequence(ExcelWorksheet worksheet, int startRow)
        {
            //Check if the start row is greater than 1
            //if start row is equal to 1 it means that there are no header because worksheet is 1 indexed
            if (startRow < 2)
            {
                Console.WriteLine("start row is less than 2");
                return new int[0];
            }

            int headerLocation = startRow - 1; //move one cell up assuming that the header is directly above the first row

            //Initialize array
            int[] sequence = new int[10];

            //Loop to fill the array
            for (int col = worksheet.Dimension.Start.Column; col <= sequence.Length; col++)
            {
                //Take cell value
                var cellValue = worksheet.Cells[headerLocation, col].Value;

                //Check first if cell is null
                if (cellValue != null)
                {
                    // Check if the cells are all string
                    if (cellValue is double doubleValue) return new int[0];
                    else if (cellValue is int intValue) return new int[0];
                    else if (cellValue is float floatValue) return new int[0];

                    //Fill the array with values based from cell header name
                    if (cellValue.ToString().Trim().ToUpper() == "LASTNAME" ||
                        cellValue.ToString().Trim().ToUpper() == "LAST NAME" ||
                        cellValue.ToString().Trim().ToUpper() == "LAST_NAME" ||
                        cellValue.ToString().Trim().ToUpper() == "LAST-NAME")
                    {
                        sequence[col - 1] = (int)StudentInfo.LastName;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "FIRSTNAME" ||
                        cellValue.ToString().Trim().ToUpper() == "FIRST NAME" ||
                        cellValue.ToString().Trim().ToUpper() == "FIRST_NAME" ||
                        cellValue.ToString().Trim().ToUpper() == "FIRST-NAME")
                    {
                        sequence[col - 1] = (int)StudentInfo.FirstName;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "MIDDLENAME" ||
                        cellValue.ToString().Trim().ToUpper() == "MIDDLE NAME" ||
                        cellValue.ToString().Trim().ToUpper() == "MIDDLE_NAME" ||
                        cellValue.ToString().Trim().ToUpper() == "MIDDLE-NAME")
                    {
                        sequence[col - 1] = (int)StudentInfo.MiddleName;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "EMAIL")
                    {
                        sequence[col - 1] = (int)StudentInfo.Email;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "ADDRESS")
                    {
                        sequence[col - 1] = (int)StudentInfo.Address;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "CONTACTNUMBER" ||
                        cellValue.ToString().Trim().ToUpper() == "CONTACT NUMBER" ||
                        cellValue.ToString().Trim().ToUpper() == "CONTACT_NUMBER" ||
                        cellValue.ToString().Trim().ToUpper() == "CONTACT-NUMBER")
                    {
                        sequence[col - 1] = (int)StudentInfo.ContactNum;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "DEPARTMENT")
                    {
                        sequence[col - 1] = (int)StudentInfo.Department;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "YEARLEVEL" ||
                        cellValue.ToString().Trim().ToUpper() == "YEAR LEVEL" ||
                        cellValue.ToString().Trim().ToUpper() == "YEAR_LEVEL" ||
                        cellValue.ToString().Trim().ToUpper() == "YEAR-LEVEL")
                    {
                        sequence[col - 1] = (int)StudentInfo.YearLevel;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "SECTION")
                    {
                        sequence[col - 1] = (int)StudentInfo.Section;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "IMAGE PATH" ||
                        cellValue.ToString().Trim().ToUpper() == "IMAGE_PATH" ||
                        cellValue.ToString().Trim().ToUpper() == "IMAGE-PATH" ||
                        cellValue.ToString().Trim().ToUpper() == "IMAGEPATH")
                    {
                        sequence[col - 1] = (int)StudentInfo.ImagePath;
                    }
                    else return new int[0];
                }
                else return new int[0]; //Return imediately if the cell is empty
            }
            return sequence;
        }
        private static int[] IdentifyTeacherColumnInfoSequence(ExcelWorksheet worksheet, int startRow)
        {
            //Check if the start row is greater than 1
            //if start row is equal to 1 it means that there are no header because worksheet is 1 indexed
            if (startRow < 2)
            {
                Console.WriteLine("start row is less than 2");
                return new int[0];
            }

            int headerLocation = startRow - 1; //move one cell up assuming that the header is directly above the first row

            //Initialize array
            int[] sequence = new int[8];

            //Loop to fill the array
            for (int col = worksheet.Dimension.Start.Column; col <= sequence.Length; col++)
            {
                //Take cell value
                var cellValue = worksheet.Cells[headerLocation, col].Value;

                //Check first if cell is null
                if (cellValue != null)
                {
                    // Check if the cells are all string
                    if (cellValue is double doubleValue) return new int[0];
                    else if (cellValue is int intValue) return new int[0];
                    else if (cellValue is float floatValue) return new int[0];

                    //Fill the array with values based from cell header name
                    if (cellValue.ToString().Trim().ToUpper() == "LASTNAME" ||
                        cellValue.ToString().Trim().ToUpper() == "LAST NAME" ||
                        cellValue.ToString().Trim().ToUpper() == "LAST_NAME" ||
                        cellValue.ToString().Trim().ToUpper() == "LAST-NAME")
                    {
                        sequence[col - 1] = (int)TeacherInfo.LastName;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "FIRSTNAME" ||
                        cellValue.ToString().Trim().ToUpper() == "FIRST NAME" ||
                        cellValue.ToString().Trim().ToUpper() == "FIRST_NAME" ||
                        cellValue.ToString().Trim().ToUpper() == "FIRST-NAME")
                    {
                        sequence[col - 1] = (int)TeacherInfo.FirstName;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "MIDDLENAME" ||
                        cellValue.ToString().Trim().ToUpper() == "MIDDLE NAME" ||
                        cellValue.ToString().Trim().ToUpper() == "MIDDLE_NAME" ||
                        cellValue.ToString().Trim().ToUpper() == "MIDDLE-NAME")
                    {
                        sequence[col - 1] = (int)TeacherInfo.MiddleName;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "EMAIL")
                    {
                        sequence[col - 1] = (int)TeacherInfo.Email;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "ADDRESS")
                    {
                        sequence[col - 1] = (int)TeacherInfo.Address;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "CONTACTNUMBER" ||
                        cellValue.ToString().Trim().ToUpper() == "CONTACT NUMBER" ||
                        cellValue.ToString().Trim().ToUpper() == "CONTACT_NUMBER" ||
                        cellValue.ToString().Trim().ToUpper() == "CONTACT-NUMBER")
                    {
                        sequence[col - 1] = (int)TeacherInfo.ContactNum;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "DEPARTMENT")
                    {
                        sequence[col - 1] = (int)TeacherInfo.Department;
                    }
                    else if (cellValue.ToString().Trim().ToUpper() == "IMAGE PATH" ||
                        cellValue.ToString().Trim().ToUpper() == "IMAGE_PATH" ||
                        cellValue.ToString().Trim().ToUpper() == "IMAGE-PATH" ||
                        cellValue.ToString().Trim().ToUpper() == "IMAGEPATH")
                    {
                        sequence[col - 1] = (int)TeacherInfo.ImagePath;
                    }
                    else return new int[0];
                }
                else return new int[0]; //Return imediately if the cell is empty
            }
            return sequence;
        }
        public static bool CheckStudentInfoFromExcel(string[] studentInfos)
        {
            //Checks email
            if (IsEmailExisting(studentInfos[(int)StudentInfo.Email]))
            {
                Console.WriteLine("Entered email check 1");
                return false;
            }
            if (!IsValidEmail(studentInfos[(int)StudentInfo.Email]))
            {
                Console.WriteLine("Entered email check 2");
                return false;
            }
            //Checks contact number
            if (!IsValidContactNumber(studentInfos[(int)StudentInfo.ContactNum]))
            {
                Console.WriteLine("Entered contact number check");
                return false;
            }
            //Checks year level
            if (!IsValidInteger(studentInfos[(int)StudentInfo.YearLevel]) &&
                int.TryParse(studentInfos[(int)StudentInfo.YearLevel], out int parsedYearLevel) &&
                parsedYearLevel > 0 && parsedYearLevel < 7)
            {
                Console.WriteLine("Entered year level check");
                return false;
            }
            //Checks file location
            if (string.IsNullOrEmpty(studentInfos[(int)StudentInfo.ImagePath]) ||
                !(studentInfos[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NO_IMAGE" ||
                studentInfos[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NO IMAGE" ||
                studentInfos[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NO-IMAGE" ||
                studentInfos[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NOIMAGE" ||
                studentInfos[(int)StudentInfo.ImagePath].ToUpper().Trim() == "N/A"))
            {
                if (!DoesFileExistAndIsImage(studentInfos[9]))
                {
                    Console.WriteLine("Entered image check");
                    return false;
                }
            }
            for (int i = 0; i < studentInfos.Length; i++)
            {
                //skip iteration
                if (i == (int)StudentInfo.Email || i == (int)StudentInfo.ContactNum ||
                    i == (int)StudentInfo.YearLevel || i == (int)StudentInfo.ImagePath) continue;
                //Checks other infos
                if (string.IsNullOrEmpty(studentInfos[i]))
                {
                    Console.WriteLine("Entered Book info is null check");
                    return false;
                }
            }
            return true;
        }
        public static bool CheckTeacherInfoFromExcel(string[] teacherInfos)
        {
            //Checks email
            if (IsEmailExisting(teacherInfos[(int)TeacherInfo.Email]))
            {
                Console.WriteLine("Entered email check 1");
                return false;
            }
            if (!IsValidEmail(teacherInfos[(int)TeacherInfo.Email]))
            {
                Console.WriteLine("Entered email check 2");
                return false;
            }
            //Checks contact number
            if (!IsValidContactNumber(teacherInfos[(int)TeacherInfo.ContactNum]))
            {
                Console.WriteLine("Entered contact number check");
                return false;
            }

            //Checks file location
            if (string.IsNullOrEmpty(teacherInfos[(int)TeacherInfo.ImagePath]) ||
                !(teacherInfos[(int)TeacherInfo.ImagePath].ToUpper().Trim() == "NO_IMAGE" ||
                teacherInfos[(int)TeacherInfo.ImagePath].ToUpper().Trim() == "NO IMAGE" ||
                teacherInfos[(int)TeacherInfo.ImagePath].ToUpper().Trim() == "NO-IMAGE" ||
                teacherInfos[(int)TeacherInfo.ImagePath].ToUpper().Trim() == "NOIMAGE" ||
                teacherInfos[(int)TeacherInfo.ImagePath].ToUpper().Trim() == "N/A"))
            {
                if (!DoesFileExistAndIsImage(teacherInfos[(int)TeacherInfo.ImagePath]))
                {
                    Console.WriteLine("Entered image check");
                    Console.WriteLine(teacherInfos[(int)TeacherInfo.ImagePath].ToUpper().Trim());
                    return false;
                }
            }
            for (int i = 0; i < teacherInfos.Length; i++)
            {
                //skip iteration
                if (i == (int)TeacherInfo.Email || i == (int)TeacherInfo.ContactNum || i == (int)TeacherInfo.ImagePath) continue;
                //Checks other infos
                if (string.IsNullOrEmpty(teacherInfos[i]))
                {
                    Console.WriteLine("Entered Teacher info is null check");
                    return false;
                }
            }
            return true;
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
        static int GetUserIdByEmailAndLastName(string email, string lastName)
        {
            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();

                    // SQL query to retrieve user ID based on email and last name
                    string query = "SELECT id FROM users WHERE Email = @Email AND LastName = @LastName";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //Add parameters to the command
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@LastName", lastName);

                        //Execute the SQL command
                        object result = command.ExecuteScalar();

                        //Check if a result was returned
                        if (result != null)
                        {
                            //Convert the result to an integer (user ID)
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            //Return -1 to indicate that the user was not found
                            return -1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    // Return -1 in case of an error
                    return -1;
                }
            }
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
        public static Employee GetEmployeeByEmployeeId(string employee_id)
        {
            Employee employee = null;

            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = "SELECT users.id, FirstName, LastName, MiddleName, Email, Address, " +
                               "Contact_number, image_path, user_level, status, employee_id, " +
                               "security_question, question_answer " +
                               "FROM users JOIN employees ON users.id = employees.user_id " +
                               "WHERE employee_id = @EmployeeId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employee_id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee(
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
                        }
                    }
                }
            }

            return employee;
        }
        public static Student GetStudentById(string student_id)
        {
            Student student = null;

            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = "SELECT users.id, FirstName, LastName, MiddleName, Email, Address, " +
                               "Contact_number, image_path, user_level, status, " +
                               "student_id, department, year_level, section " +
                               "FROM users JOIN students ON users.id = students.user_id " +
                               "WHERE student_id = @StudentId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", student_id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            student = new Student(
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
                        }
                    }
                }
            }

            return student;
        }
        public static Teacher GetTeacherById(string teacher_id)
        {
            Teacher teacher = null;

            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = "SELECT users.id, FirstName, LastName, MiddleName, Email, Address, " +
                               "Contact_number, image_path, user_level, status, teacher_id, " +
                               "department " +
                               "FROM users JOIN teachers ON users.id = teachers.user_id " +
                               "WHERE teacher_id = @TeacherId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeacherId", teacher_id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            teacher = new Teacher(
                                reader["teacher_id"].ToString(),
                                Convert.ToInt32(reader["id"]),
                                reader["FirstName"].ToString(),
                                reader["LastName"].ToString(),
                                reader["MiddleName"].ToString(),
                                reader["Email"].ToString(),
                                reader["Address"].ToString(),
                                reader["Contact_number"].ToString(),
                                reader["department"].ToString(),
                                reader["image_path"].ToString(),
                                reader["status"].ToString()
                            );
                        }
                    }
                }
            }

            return teacher;
        }

        //FOR INSERTING NEW USER RECORDS IN THE DATABASE(DONE)
        private static void AddUser(string firstName, string lastName, string middleName, string email, string address,
            string contactNum, int userLevel, string imagePath = "NO_IMAGE")
        {
            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                try
                {
                    //Open a connection to database
                    connection.Open();
                    Console.WriteLine("Connected to the database.");

                    //Prepare query 
                    string insertQuery = "INSERT INTO users(FirstName, LastName, MiddleName, Email, Address, Contact_number, image_path, user_level) " +
                        "VALUES(@firstName, @lastName, @middleName, @email, @address, @contactNum, @imagePath, @userLevel)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        //Add parameters to the command
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@middleName", middleName);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@contactNum", contactNum);
                        command.Parameters.AddWithValue("@imagePath", imagePath);
                        command.Parameters.AddWithValue("@userLevel", userLevel);

                        //Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        //Check if operation was successful
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Operation successful. {rowsAffected} rows affected.");
                        }
                        else
                        {
                            Console.WriteLine("No rows affected. Something might be wrong in inserting users.");
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
        public static void AddAdminOrEmployee(string email, string lastName,
            string firstName, string middleName, string address, string contactNum, int userLevel, string password,
            string securityQuestion = "NO_SECURITY_QUESTION", string securityAnswer = "NO_SECURITY_ANSWER", string imagePath = "NO_IMAGE")
        {
            //Call method AddUser to insert information in the users table
            AddUser(firstName, lastName, middleName, email, address, contactNum, userLevel, imagePath);

            //Condition to know what table will be used
            string tableName = "";
            if (userLevel == (int)UserLevel.Admin)
            {
                tableName = "admin";
            }
            else if (userLevel == (int)UserLevel.Employee)
            {
                tableName = "employees";
            }
            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                try
                {
                    //Open a connection to database
                    connection.Open();
                    Console.WriteLine("Connected to the database.");

                    //Prepare query 
                    string insertQuery = "INSERT INTO " + tableName + "(user_id, password, security_question, question_answer) " +
                        "VALUES(@userId, @hashedPass, @securityQuestion, @securityAnswer)";

                    //Find userID
                    int userID = GetUserIdByEmailAndLastName(email, lastName);

                    if (userID == -1)
                    {
                        Console.WriteLine("user not found");
                        return;
                    }

                    //hash password
                    string hashedPass = HashPassword(password);

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        //Add parameters to the command
                        command.Parameters.AddWithValue("@userId", userID);
                        command.Parameters.AddWithValue("@hashedPass", hashedPass);
                        command.Parameters.AddWithValue("@securityQuestion", securityQuestion);
                        command.Parameters.AddWithValue("@securityAnswer", securityAnswer);

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
        public static void AddStudent(string firstName, string lastName, string middleName, string email, string address,
            string contactNum, string department, int yearLevel, string section, string imagePath = "NO_IMAGE")
        {
            //Call method AddUser to insert information in the users table
            AddUser(firstName, lastName, middleName, email, address, contactNum, (int)UserLevel.Student, imagePath);

            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                try
                {
                    //Open a connection to database
                    connection.Open();
                    Console.WriteLine("Connected to the database.");

                    //Prepare query 
                    string insertQuery = "INSERT INTO students(user_id, department, year_level, section) " +
                        "VALUES(@userId, @department, @yearLevel, @section)";

                    //Find userID
                    int userID = GetUserIdByEmailAndLastName(email, lastName);

                    if (userID == -1)
                    {
                        Console.WriteLine("user not found");
                        return;
                    }

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        //Add parameters to the command
                        command.Parameters.AddWithValue("@userId", userID);
                        command.Parameters.AddWithValue("@department", department);
                        command.Parameters.AddWithValue("@yearLevel", yearLevel);
                        command.Parameters.AddWithValue("@section", section);

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
        public static void AddTeacher(string firstName, string lastName, string middleName, string email, string address,
            string contactNum, string department, string imagePath = "NO_IMAGE")
        {
            //Call method AddUser to insert information in the users table
            AddUser(firstName, lastName, middleName, email, address, contactNum, (int)UserLevel.Teacher, imagePath);

            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                try
                {
                    //Open a connection to database
                    connection.Open();
                    Console.WriteLine("Connected to the database.");

                    //Prepare query 
                    string insertQuery = "INSERT INTO teachers(user_id, department) " +
                        "VALUES(@userId, @department)";

                    //Find userID
                    int userID = GetUserIdByEmailAndLastName(email, lastName);

                    if (userID == -1)
                    {
                        Console.WriteLine("user not found");
                        return;
                    }

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        //Add parameters to the command
                        command.Parameters.AddWithValue("@userId", userID);
                        command.Parameters.AddWithValue("@department", department);

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
        public static void AddStudentByExcel(string fileLocation, string workSheetLocation, int startRow)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; //Indicates to the dependency that this is for non-commercial use

            using (var package = new ExcelPackage(new FileInfo(fileLocation)))
            {
                if (package != null)
                {
                    //.WriteLine(package.Workbook.Worksheets.Count); Just for debug
                    var worksheet = package.Workbook.Worksheets[workSheetLocation];
                    //if (worksheet == null) Console.WriteLine("is null"); Just for debug

                    //Check if the worksheet exists
                    if (worksheet != null)
                    {
                        //Iterate through the rows and columns
                        Console.WriteLine(worksheet.Dimension.End.Row.ToString() + " Rows");

                        for (int row = startRow; row <= worksheet.Dimension.End.Row; row++)
                        {
                            string[] colValues = new string[10];
                            for (int col = worksheet.Dimension.Start.Column; col <= colValues.Length; col++)
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
                                //Array to identify each column that has corresponding values
                                int[] sequence = IdentifyStudentColumnInfoSequence(worksheet, startRow);

                                //Check if header is appropriate and describes the required book info
                                if (sequence.Length != 0)
                                {
                                    //Sort info
                                    SortInfoBaseOnSequence(sequence, colValues);
                                }
                                else return; //Return immediately to avoid insertion of incorrect information
                            }
                            //Check if all infos provided is valid
                            if (CheckStudentInfoFromExcel(colValues))
                            {
                                if (string.IsNullOrEmpty(colValues[(int)StudentInfo.ImagePath]) ||
                                    colValues[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NO_IMAGE" ||
                                    colValues[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NO IMAGE" ||
                                    colValues[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NO-IMAGE" ||
                                    colValues[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NOIMAGE" ||
                                    colValues[(int)StudentInfo.ImagePath].ToUpper().Trim() == "N/A")
                                {
                                    AddStudent(
                                        colValues[(int)StudentInfo.FirstName],
                                        colValues[(int)StudentInfo.LastName],
                                        colValues[(int)StudentInfo.MiddleName],
                                        colValues[(int)StudentInfo.Email],
                                        colValues[(int)StudentInfo.Address],
                                        colValues[(int)StudentInfo.ContactNum],
                                        colValues[(int)StudentInfo.Department],
                                        int.Parse(colValues[(int)StudentInfo.YearLevel]),
                                        colValues[(int)StudentInfo.Section]
                                        );
                                }
                                else
                                {
                                    AddStudent(
                                        colValues[(int)StudentInfo.FirstName],
                                        colValues[(int)StudentInfo.LastName],
                                        colValues[(int)StudentInfo.MiddleName],
                                        colValues[(int)StudentInfo.Email],
                                        colValues[(int)StudentInfo.Address],
                                        colValues[(int)StudentInfo.ContactNum],
                                        colValues[(int)StudentInfo.Department],
                                        int.Parse(colValues[(int)StudentInfo.YearLevel]),
                                        colValues[(int)StudentInfo.Section],
                                        colValues[(int)StudentInfo.ImagePath]
                                        );
                                }

                            }
                        }
                        Console.Write("Student insert from excel finished");
                    }
                }
            }
        }
        public static void AddTeacherByExcel(string fileLocation, string workSheetLocation, int startRow)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; //Indicates to the dependency that this is for non-commercial use

            using (var package = new ExcelPackage(new FileInfo(fileLocation)))
            {
                if (package != null)
                {
                    //.WriteLine(package.Workbook.Worksheets.Count); Just for debug
                    var worksheet = package.Workbook.Worksheets[workSheetLocation];
                    //if (worksheet == null) Console.WriteLine("is null"); Just for debug

                    //Check if the worksheet exists
                    if (worksheet != null)
                    {
                        //Iterate through the rows and columns
                        Console.WriteLine(worksheet.Dimension.End.Row.ToString() + " Rows");

                        for (int row = startRow; row <= worksheet.Dimension.End.Row; row++)
                        {
                            string[] colValues = new string[8];
                            for (int col = worksheet.Dimension.Start.Column; col <= colValues.Length; col++)
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
                                //Array to identify each column that has corresponding values
                                int[] sequence = IdentifyTeacherColumnInfoSequence(worksheet, startRow);

                                //Check if header is appropriate and describes the required book info
                                if (sequence.Length != 0)
                                {
                                    //Sort info
                                    SortInfoBaseOnSequence(sequence, colValues);
                                }
                                else return; //Return immediately to avoid insertion of incorrect information
                            }
                            //Check if all infos provided is valid
                            if (CheckTeacherInfoFromExcel(colValues))
                            {
                                if (string.IsNullOrEmpty(colValues[(int)TeacherInfo.ImagePath]) ||
                                    colValues[(int)TeacherInfo.ImagePath].ToUpper().Trim() == "NO_IMAGE" ||
                                    colValues[(int)TeacherInfo.ImagePath].ToUpper().Trim() == "NO IMAGE" ||
                                    colValues[(int)TeacherInfo.ImagePath].ToUpper().Trim() == "NO-IMAGE" ||
                                    colValues[(int)TeacherInfo.ImagePath].ToUpper().Trim() == "NOIMAGE" ||
                                    colValues[(int)TeacherInfo.ImagePath].ToUpper().Trim() == "N/A")
                                {
                                    AddTeacher(
                                            colValues[(int)TeacherInfo.FirstName],
                                            colValues[(int)TeacherInfo.LastName],
                                            colValues[(int)TeacherInfo.MiddleName],
                                            colValues[(int)TeacherInfo.Email],
                                            colValues[(int)TeacherInfo.Address],
                                            colValues[(int)TeacherInfo.ContactNum],
                                            colValues[(int)TeacherInfo.Department]
                                        );
                                }
                                else
                                {
                                    AddTeacher(
                                            colValues[(int)TeacherInfo.FirstName],
                                            colValues[(int)TeacherInfo.LastName],
                                            colValues[(int)TeacherInfo.MiddleName],
                                            colValues[(int)TeacherInfo.Email],
                                            colValues[(int)TeacherInfo.Address],
                                            colValues[(int)TeacherInfo.ContactNum],
                                            colValues[(int)TeacherInfo.Department],
                                            colValues[(int)TeacherInfo.ImagePath]
                                        );
                                }

                            }
                        }
                        Console.Write("Student insert from excel finished");
                    }
                }
            }
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

        //FOR UPDATING USER INFORMATION (NEXT)
        public static bool UpdateSecurityQuestion(string adminOrEmployeeId, int userLevel, string newQuestion)
        {
            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();

                    //Define the SQL query to update the security_question column
                    string query = "UPDATE employees SET security_question = @NewQuestion WHERE employee_id = @AdminOrEmployeeId";
                    if (userLevel == (int)UserLevel.Admin) query = "UPDATE admin SET security_question = @NewQuestion WHERE admin_id = @AdminOrEmployeeId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //Add parameters to the command
                        command.Parameters.AddWithValue("@NewQuestion", newQuestion);
                        command.Parameters.AddWithValue("@AdminOrEmployeeId", adminOrEmployeeId);

                        //Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the update was successful
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }
        public static bool UpdateSecurityAnswer(string adminOrEmployeeId, int userLevel, string newAnswer)
        {
            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();

                    //Define the SQL query to update the security_question column
                    string query = "UPDATE employees SET security_answer = @NewAnswer WHERE employee_id = @AdminOrEmployeeId";
                    if (userLevel == (int)UserLevel.Admin) query = "UPDATE admin SET security_answer = @NewAnswer WHERE admin_id = @AdminOrEmployeeId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //Add parameters to the command
                        command.Parameters.AddWithValue("@NewAnswer", HashPassword(newAnswer));
                        command.Parameters.AddWithValue("@AdminOrEmployeeId", adminOrEmployeeId);

                        //Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the update was successful
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }
        public static void UpdateStudentInformation(int studentUserId, string newDepartment, int newYearLevel, string newSection, string firstName, string lastName, string middleName, string address, string contactNumber, string imagePath)
        {
            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string updateQuery = @"UPDATE students
                                   SET department = @NewDepartment,
                                       year_level = @NewYearLevel,
                                       section = @NewSection
                                   WHERE id = @StudentId";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentUserId);
                    cmd.Parameters.AddWithValue("@NewDepartment", newDepartment);
                    cmd.Parameters.AddWithValue("@NewYearLevel", newYearLevel);
                    cmd.Parameters.AddWithValue("@NewSection", newSection);

                    UpdateUserInformation(studentUserId, firstName, lastName, middleName, address, contactNumber, imagePath);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Student information updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("No rows were affected. Student with the specified ID not found.");
                    }
                }
            }
        }
        public static void UpdateTeacherInformation(int teacherUserId, string newDepartment, string firstName, string lastName, string middleName, string address, string contactNumber, string imagePath)
        {
            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string updateQuery = @"UPDATE Teacher
                                   SET department = @NewDepartment
                                   WHERE user_id = @user_Id";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@user_Id", teacherUserId);
                    cmd.Parameters.AddWithValue("@NewDepartment", newDepartment);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    UpdateUserInformation(teacherUserId, firstName, lastName, middleName, address, contactNumber, imagePath);
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Student information updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("No rows were affected. Student with the specified ID not found.");
                    }
                }
            }
        }
        private static void UpdateUserInformation(int userId, string firstName, string lastName, string middleName, string address, string contactNumber, string imagePath)
        {
            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string updateQuery = @"UPDATE users
                                   SET FirstName = @FirstName,
                                       LastName = @LastName,
                                       MiddleName = @MiddleName,                                      
                                       Address = @Address,
                                       Contact_number = @ContactNumber,
                                       image_path = @ImagePath                                    
                                   WHERE id = @UserId";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@MiddleName", middleName);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("@ImagePath", imagePath);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("User information updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("No rows were affected. User with the specified ID not found.");
                    }
                }
            }
        }
        #endregion
    }
}
