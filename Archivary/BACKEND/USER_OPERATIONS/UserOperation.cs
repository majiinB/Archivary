using Archivary.BACKEND.OBJECTS;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Archivary.BACKEND.USER_OPERATIONS
{
    public class UserOperation
    {
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
            MiddleInitial = 2,
            Email = 3,
            BlockNo = 4,
            Street = 5,
            Barangay = 6,
            City = 7,
            ContactNum = 8,
            Department = 9,
            YearLevel = 10,
            Section = 11,
            ImagePath = 12,
        }
        public enum TeacherInfo
        {
            LastName = 0,
            FirstName = 1,
            MiddleInitial = 2,
            Email = 3,
            BlockNo = 4,
            Street = 5,
            Barangay = 6,
            City = 7,
            ContactNum = 8,
            Department = 9,
            ImagePath = 10
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
        public static string GeneratePassword(int length = 12)
        {
            // Define characters to use in the password
            string characters = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ123456789";

            // Generate the password using Linq and Random
            Random random = new Random();
            string password = new string(Enumerable.Repeat(characters, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return password;
        }

        //STRING MANIPULATION
        public static string[] SplitAddress(string address)
        {
            // Split the address using the comma as a delimiter
            string[] components = address.Split(',');

            // Trim each component to remove leading and trailing whitespaces
            for (int i = 0; i < components.Length; i++)
            {
                components[i] = components[i].Trim();
            }

            // Check if the array has the expected number of components
            if (components.Length != 4)
            {
                // Return a default value (e.g., "N/A") in case of an error
                return new string[] { "N/A", "N/A", "N/A", "N/A" };
            }

            return components;
        }

        //FOR INPUT VALIDATION
        public static string[] IsUserInputValid(string firstName, string lastName, string middleInitial, string email, string address, string contactNum,
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
            if (string.IsNullOrEmpty(middleInitial))
            {
                errorMessage[0] = "Invalid Middle Initial";
                errorMessage[1] = "Middle initial can't be empty";
                return errorMessage;
            }
            if (!IsOnlyCharacterOrNA(middleInitial))
            {
                errorMessage[0] = "Invalid Middle Initial";
                errorMessage[1] = "Middle intial can only be a character";
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
            if (!IsValidInteger(yearLevel))
            {
                if (!(int.TryParse(yearLevel, out int parsedYearLevel) && parsedYearLevel > 0 && parsedYearLevel < 7))
                {
                    if (!(yearLevel == "No_yearLevel"))
                    {
                        errorMessage[0] = "Invalid Year Level";
                        errorMessage[1] = "Year level must be numeric and ranges form 1-6";
                        return errorMessage;
                    }
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
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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
        public static bool IsOnlyCharacterOrNA(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false; // Empty or null string is not allowed
            }

            // Remove trailing period if it exists
            input = input.TrimEnd('.');

            // Check if the input is a single character or "N/A"
            return (input.Length == 1 && char.IsLetter(input[0])) || input.ToUpper() == "N/A";
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
        public static bool DoesFileExistAndIsXlsx(string filePath)
        {
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                return false;
            }

            // Check if the file extension is XLSX
            string extension = Path.GetExtension(filePath);
            return string.Equals(extension, ".xlsx", StringComparison.OrdinalIgnoreCase);
        }

        private static IdentificationResult IdentifyStudentColumnInfoSequence(ExcelWorksheet worksheet, int startRow)
        {
            //Check if the start row is greater than 1
            //if start row is equal to 1 it means that there are no header because worksheet is 1 indexed
            if (startRow < 2) return IdentificationResult.CreateError("Start Row is Less Than 2");

            int headerLocation = startRow - 1; //move one cell up assuming that the header is directly above the first row

            //Initialize array
            int[] sequence = new int[13];

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
                        else if (cellValue.ToString().Trim().ToUpper() == "MIDDLEINTIAL" ||
                            cellValue.ToString().Trim().ToUpper() == "MIDDLE INITIAL" ||
                            cellValue.ToString().Trim().ToUpper() == "MIDDLE_INITIAL" ||
                            cellValue.ToString().Trim().ToUpper() == "MIDDLE-INITIAL")
                        {
                            sequence[col - 1] = (int)StudentInfo.MiddleInitial;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "EMAIL" ||
                            cellValue.ToString().Trim().ToUpper() == "EMAIL ADDRESS")
                        {
                            sequence[col - 1] = (int)StudentInfo.Email;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "BLOCK NO." ||
                            cellValue.ToString().Trim().ToUpper() == "BLOCK NO" ||
                            cellValue.ToString().Trim().ToUpper() == "BLOCK NUMBER" ||
                            cellValue.ToString().Trim().ToUpper() == "BLOCK" ||
                            cellValue.ToString().Trim().ToUpper() == "HOUSE NUMBER" ||
                            cellValue.ToString().Trim().ToUpper() == "HOUSE NO." ||
                            cellValue.ToString().Trim().ToUpper() == "BLOCK NO" ||
                            cellValue.ToString().Trim().ToUpper() == "HOME NO." ||
                            cellValue.ToString().Trim().ToUpper() == "HOME NO" ||
                            cellValue.ToString().Trim().ToUpper() == "BLOCK NUMBER")
                        {
                            sequence[col - 1] = (int)StudentInfo.BlockNo;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "STREET")
                        {
                            sequence[col - 1] = (int)StudentInfo.Street;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "BARANGAY")
                        {
                            sequence[col - 1] = (int)StudentInfo.Barangay;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "CITY")
                        {
                            sequence[col - 1] = (int)StudentInfo.City;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "CONTACTNUMBER" ||
                            cellValue.ToString().Trim().ToUpper() == "CONTACT NUMBER" ||
                            cellValue.ToString().Trim().ToUpper() == "CONTACT_NUMBER" ||
                            cellValue.ToString().Trim().ToUpper() == "CONTACT-NUMBER")
                        {
                            sequence[col - 1] = (int)StudentInfo.ContactNum;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "DEPARTMENT" ||
                            cellValue.ToString().Trim().ToUpper() == "COLLEGE DEPARTMENT")
                        {
                            sequence[col - 1] = (int)StudentInfo.Department;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "YEARLEVEL" ||
                            cellValue.ToString().Trim().ToUpper() == "YEAR LEVEL" ||
                            cellValue.ToString().Trim().ToUpper() == "YEAR_LEVEL" ||
                            cellValue.ToString().Trim().ToUpper() == "YEAR-LEVEL" ||
                            cellValue.ToString().Trim().ToUpper() == "YEAR")
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
                            cellValue.ToString().Trim().ToUpper() == "IMAGEPATH" ||
                            cellValue.ToString().Trim().ToUpper() == "PROFILE PICTURE" ||
                            cellValue.ToString().Trim().ToUpper() == "PROFILE_PICTURE")
                        {
                            sequence[col - 1] = (int)StudentInfo.ImagePath;
                        }
                        else return IdentificationResult.CreateError($"Column {headerName} in your header is not in the right format or does not correctly identify the column");
                    }
                    else return IdentificationResult.CreateError($"Column {col} in your header is empty");
                }
            }
            return IdentificationResult.CreateSuccess(sequence);
        }
        private static IdentificationResult IdentifyTeacherColumnInfoSequence(ExcelWorksheet worksheet, int startRow)
        {
            //Check if the start row is greater than 1
            //if start row is equal to 1 it means that there are no header because worksheet is 1 indexed
            if (startRow < 2) return IdentificationResult.CreateError("Start Row is Less Than 2");

            int headerLocation = startRow - 1; //move one cell up assuming that the header is directly above the first row

            //Initialize array
            int[] sequence = new int[11];

            // Track encountered headers
            HashSet<string> encounteredHeaders = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            for (int row = headerLocation; row == headerLocation; row++)
            {
                //Loop to fill the array
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
                        else if (cellValue.ToString().Trim().ToUpper() == "MIDDLEINTIAL" ||
                            cellValue.ToString().Trim().ToUpper() == "MIDDLE INITIAL" ||
                            cellValue.ToString().Trim().ToUpper() == "MIDDLE_INITIAL" ||
                            cellValue.ToString().Trim().ToUpper() == "MIDDLE-INITIAL")
                        {
                            sequence[col - 1] = (int)TeacherInfo.MiddleInitial;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "EMAIL" ||
                            cellValue.ToString().Trim().ToUpper() == "EMAIL ADDRESS")
                        {
                            sequence[col - 1] = (int)TeacherInfo.Email;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "BLOCK NO." ||
                            cellValue.ToString().Trim().ToUpper() == "BLOCK NO" ||
                            cellValue.ToString().Trim().ToUpper() == "BLOCK NUMBER" ||
                            cellValue.ToString().Trim().ToUpper() == "BLOCK" ||
                            cellValue.ToString().Trim().ToUpper() == "HOUSE NUMBER" ||
                            cellValue.ToString().Trim().ToUpper() == "HOUSE NO." ||
                            cellValue.ToString().Trim().ToUpper() == "BLOCK NO" ||
                            cellValue.ToString().Trim().ToUpper() == "HOME NO." ||
                            cellValue.ToString().Trim().ToUpper() == "HOME NO" ||
                            cellValue.ToString().Trim().ToUpper() == "BLOCK NUMBER")
                        {
                            sequence[col - 1] = (int)TeacherInfo.BlockNo;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "STREET")
                        {
                            sequence[col - 1] = (int)TeacherInfo.Street;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "BARANGAY")
                        {
                            sequence[col - 1] = (int)TeacherInfo.Barangay;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "CITY")
                        {
                            sequence[col - 1] = (int)TeacherInfo.City;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "CONTACTNUMBER" ||
                            cellValue.ToString().Trim().ToUpper() == "CONTACT NUMBER" ||
                            cellValue.ToString().Trim().ToUpper() == "CONTACT_NUMBER" ||
                            cellValue.ToString().Trim().ToUpper() == "CONTACT-NUMBER")
                        {
                            sequence[col - 1] = (int)TeacherInfo.ContactNum;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "DEPARTMENT" ||
                            cellValue.ToString().Trim().ToUpper() == "COLLEGE DEPARTMENT")
                        {
                            sequence[col - 1] = (int)TeacherInfo.Department;
                        }
                        else if (cellValue.ToString().Trim().ToUpper() == "IMAGE PATH" ||
                            cellValue.ToString().Trim().ToUpper() == "IMAGE_PATH" ||
                            cellValue.ToString().Trim().ToUpper() == "IMAGE-PATH" ||
                            cellValue.ToString().Trim().ToUpper() == "IMAGEPATH" ||
                            cellValue.ToString().Trim().ToUpper() == "PROFILE PICTURE" ||
                            cellValue.ToString().Trim().ToUpper() == "PROFILE_PICTURE")
                        {
                            sequence[col - 1] = (int)TeacherInfo.ImagePath;
                        }
                        else return IdentificationResult.CreateError($"Column {headerName} in your header is not in the right format or does not correctly identify the column");
                    }
                    else return IdentificationResult.CreateError($"Column {col} in your header is empty");
                }
            }
            return IdentificationResult.CreateSuccess(sequence);
        }
        public static (bool isValid, string errorMessage) CheckStudentInfoFromExcel(string[] studentInfos)
        {
            // Checks middle initial
            if (!IsOnlyCharacterOrNA(studentInfos[(int)StudentInfo.MiddleInitial]))
            {
                return (false, "Invalid middle initial");
            }

            // Checks email
            if (IsEmailExisting(studentInfos[(int)StudentInfo.Email]))
            {
                return (false, "Email already exists");
            }
            if (!IsValidEmail(studentInfos[(int)StudentInfo.Email]))
            {
                return (false, "Invalid email format");
            }

            // Checks contact number
            if (!IsValidContactNumber(studentInfos[(int)StudentInfo.ContactNum]))
            {
                return (false, "Invalid contact number");
            }

            // Checks year level
            if (!IsValidInteger(studentInfos[(int)StudentInfo.YearLevel]) ||
                !int.TryParse(studentInfos[(int)StudentInfo.YearLevel], out int parsedYearLevel) ||
                parsedYearLevel <= 0 || parsedYearLevel >= 7)
            {
                return (false, "Invalid year level");
            }

            // Checks file location
            if (string.IsNullOrEmpty(studentInfos[(int)StudentInfo.ImagePath]) ||
                !(studentInfos[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NO_IMAGE" ||
                  studentInfos[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NO IMAGE" ||
                  studentInfos[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NO-IMAGE" ||
                  studentInfos[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NOIMAGE" ||
                  studentInfos[(int)StudentInfo.ImagePath].ToUpper().Trim() == "N/A"))
            {
                if (!DoesFileExistAndIsImage(studentInfos[(int)StudentInfo.ImagePath]))
                {
                    return (false, "Invalid image file or file does not exist");
                }
            }

            string[] headerNames = { "Last Name", "First Name", "Middle Initial", "Email Address",
                "Block No.", "Street", "Barangay", "City", "Contact Number", "College Department", "Year Level", "Section",  "Image Path" };

            for (int i = 0; i < studentInfos.Length; i++)
            {
                // Skip iteration
                if (i == (int)StudentInfo.Email || i == (int)StudentInfo.ContactNum ||
                    i == (int)StudentInfo.YearLevel || i == (int)StudentInfo.ImagePath || i == (int)StudentInfo.MiddleInitial) continue;

                // Checks other infos
                if (string.IsNullOrEmpty(studentInfos[i]))
                {
                    return (false, $"Entered student info is null in column {headerNames[i]}");
                }
            }
            return (true, null); // No errors
        }
        public static (bool isValid, string errorMessage) CheckTeacherInfoFromExcel(string[] teacherInfos)
        {
            // Checks middle initial
            if (!IsOnlyCharacterOrNA(teacherInfos[(int)TeacherInfo.MiddleInitial]))
            {
                return (false, "Invalid middle initial");
            }
            //Checks email
            if (IsEmailExisting(teacherInfos[(int)TeacherInfo.Email]))
            {
                return (false, "Email already exists");
            }
            if (!IsValidEmail(teacherInfos[(int)TeacherInfo.Email]))
            {
                return (false, "Invalid email format");
            }
            //Checks contact number
            if (!IsValidContactNumber(teacherInfos[(int)TeacherInfo.ContactNum]))
            {
                return (false, "Invalid contact number");
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
                    return (false, "Invalid image file or file does not exist");
                }
            }
            string[] headerNames = { "Last Name", "First Name", "Middle Initial", "Email Address",
                "Block No.", "Street", "Barangay", "City", "Contact Number", "College Department", "Image Path" };
            for (int i = 0; i < teacherInfos.Length; i++)
            {
                //skip iteration
                if (i == (int)TeacherInfo.Email || i == (int)TeacherInfo.ContactNum || i == (int)TeacherInfo.ImagePath ||
                    i == (int)StudentInfo.MiddleInitial) continue;
                //Checks other infos
                if (string.IsNullOrEmpty(teacherInfos[i]))
                {
                    return (false, $"Entered student info is null in column {headerNames[i]}");
                }
            }
            return (true, null); // No errors
        }

        //FOR EXTRACTING INFORMATION IN THE DATABASE
        private static string[] GetUserByEmail(string email)
        {
            string[] result = new string[10];
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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
        public static string GetPassword(string userId)
        {
            bool isAdmin = userId.StartsWith("AA", StringComparison.OrdinalIgnoreCase);
            bool isEmployee = userId.StartsWith("AE", StringComparison.OrdinalIgnoreCase);

            if (isAdmin || isEmployee)
            {
                string tableName = isAdmin ? "admin" : "employee";
                string idColumnName = isAdmin ? "admin_id" : "employee_id";

                using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
                {
                    connection.Open();

                    string query = $"SELECT password FROM {tableName} WHERE {idColumnName} = @userId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);

                        object result = command.ExecuteScalar();

                        // Assuming result is not null; adjust error handling accordingly
                        return result.ToString();
                    }
                }
            }

            return null; // Or throw an exception, depending on your requirements
        }
        public static List<BookStatusInfo> GetBookStatusList(int userId, int daysToAdd)
        {
            //Create a list to store book status information
            List<BookStatusInfo> bookStatusList = new List<BookStatusInfo>();

            //query to retrieve information from the database
            string sqlQuery = @"
            SELECT 
                b.title,
                bb.borrowed_at,
                DATE_ADD(bb.borrowed_at, INTERVAL @DaysToAdd DAY) AS return_due_date,
                bb.is_returned,
            CASE
                WHEN bb.is_returned = 1 THEN rb.return_at
                ELSE 'Not Returned'
            END AS return_date,
            CASE
                WHEN bb.is_returned = 0 AND CURRENT_TIMESTAMP() > DATE_ADD(bb.borrowed_at, INTERVAL @DaysToAdd DAY) THEN 'Overdue'
                WHEN bb.is_returned = 1 AND rb.return_at > DATE_ADD(bb.borrowed_at, INTERVAL @DaysToAdd DAY) THEN 'Overdue'
                ELSE 'Not Overdue'
            END AS status
            FROM borrowed_books bb
                JOIN books b ON bb.book_id = b.id
                LEFT JOIN returned_books rb ON bb.borrower_id = rb.borrower_id
             WHERE bb.borrower_id = @UserId;
            ";

            try
            {
                //Open a MySqlConnection
                using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    //Create a MySqlCommand and set the parameters
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@DaysToAdd", daysToAdd);

                        //Execute the query and read the results
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Retrieve information from the query results
                                    BookStatusInfo bookStatus = new BookStatusInfo()
                                    {
                                        Title = reader["title"].ToString(),
                                        BorrowedAt = (DateTime)reader["borrowed_at"],
                                        ReturnDueDate = (DateTime)reader["return_due_date"],
                                        IsReturned = Convert.ToBoolean(reader["is_returned"])
                                    };

                                    if (bookStatus.IsReturned)
                                    {
                                        bookStatus.ReturnDate = reader["return_date"] != DBNull.Value
                                            ? (DateTime)reader["return_date"]
                                            : DateTime.MinValue;
                                    }
                                    else
                                    {
                                        bookStatus.ReturnDate = DateTime.MinValue;
                                    }

                                    bookStatus.Status = reader["status"].ToString();

                                    // Add the BookStatusInfo to the list
                                    bookStatusList.Add(bookStatus);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, throw, etc.)
                Console.WriteLine($"Error: {ex.Message}");
            }

            return bookStatusList;
        }
        public static List<BookStatusInfo> GetEmployeeBookStatusList(int userId, int daysToAdd)
        {
            //Create a list to store book status information
            List<BookStatusInfo> bookStatusList = new List<BookStatusInfo>();

            //query to retrieve information from the database
            string sqlQuery = @"
            SELECT 
                b.title,
                bb.borrowed_at,
                DATE_ADD(bb.borrowed_at, INTERVAL @DaysToAdd DAY) AS return_due_date,
                bb.is_returned,
            CASE
                WHEN bb.is_returned = 1 THEN rb.return_at
                ELSE 'Not Returned'
            END AS return_date,
            CASE
                WHEN bb.is_returned = 0 AND CURRENT_TIMESTAMP() > DATE_ADD(bb.borrowed_at, INTERVAL @DaysToAdd DAY) THEN 'Overdue'
                WHEN bb.is_returned = 1 AND rb.return_at > DATE_ADD(bb.borrowed_at, INTERVAL @DaysToAdd DAY) THEN 'Overdue'
                ELSE 'Not Overdue'
            END AS status
            FROM borrowed_books bb
                JOIN books b ON bb.book_id = b.id
                LEFT JOIN returned_books rb ON bb.borrower_id = rb.borrower_id
             WHERE bb.librarian_id = @UserId;
            ";

            try
            {
                //Open a MySqlConnection
                using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    //Create a MySqlCommand and set the parameters
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@DaysToAdd", daysToAdd);

                        //Execute the query and read the results
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Retrieve information from the query results
                                    BookStatusInfo bookStatus = new BookStatusInfo()
                                    {
                                        Title = reader["title"].ToString(),
                                        BorrowedAt = (DateTime)reader["borrowed_at"],
                                        ReturnDueDate = (DateTime)reader["return_due_date"],
                                        IsReturned = Convert.ToBoolean(reader["is_returned"])
                                    };

                                    if (bookStatus.IsReturned)
                                    {
                                        bookStatus.ReturnDate = reader["return_date"] != DBNull.Value
                                            ? (DateTime)reader["return_date"]
                                            : DateTime.MinValue;
                                    }
                                    else
                                    {
                                        bookStatus.ReturnDate = DateTime.MinValue;
                                    }

                                    bookStatus.Status = reader["status"].ToString();

                                    // Add the BookStatusInfo to the list
                                    bookStatusList.Add(bookStatus);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, throw, etc.)
                Console.WriteLine($"Error: {ex.Message}");
            }

            return bookStatusList;
        }
        //FOR INSERTING NEW USER RECORDS IN THE DATABASE(DONE)
        private static bool AddUser(string firstName, string lastName, string middleName, string email, string address,
            string contactNum, int userLevel, string imagePath = "NO_IMAGE")
        {
            bool condition = false;
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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
                        command.Parameters.AddWithValue("@middleName", middleName.ToUpper().Trim().Trim('.'));
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
                            condition = true;
                        }
                        else
                        {
                            condition = false;
                        }
                    }

                }
                catch (Exception ex)
                {
                    condition = false;
                }
                finally { connection.Close(); }
            }
            return condition;
        }
        public static bool AddAdminOrEmployee(string email, string lastName,
            string firstName, string middleName, string address, string contactNum, int userLevel, string password, string imagePath = "NO_IMAGE",
            string securityQuestion = "NO_SECURITY_QUESTION", string securityAnswer = "NO_SECURITY_ANSWER")
        {
            bool condition = false;

            //Call method AddUser to insert information in the users table
            bool flag = AddUser(firstName, lastName, middleName, email, address, contactNum, userLevel, imagePath);

            if (!flag)
            {
                return condition;
            }

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
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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
                        return condition;
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
                            condition = true;
                        }
                        else
                        {
                            condition = false;
                        }
                    }

                }
                catch (Exception ex)
                {
                    condition = false;
                }
                finally { connection.Close(); }
            }
            return condition;
        }
        public static bool AddStudent(string firstName, string lastName, string middleName, string email, string address,
            string contactNum, string department, int yearLevel, string section, string imagePath = "NO_IMAGE")
        {
            bool condition = false;
            //Call method AddUser to insert information in the users table
            bool flag = AddUser(firstName, lastName, middleName, email, address, contactNum, (int)UserLevel.Student, imagePath);

            //Checks if adduser is successful
            if (!flag)
            {
                return condition;
            }

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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
                        return condition;
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
                            condition = true;
                        }
                        else
                        {
                            condition = false;
                        }
                    }

                }
                catch (Exception ex)
                {
                    condition = false;
                }
                finally { connection.Close(); }
            }
            return condition;
        }
        public static bool AddTeacher(string firstName, string lastName, string middleName, string email, string address,
            string contactNum, string department, string imagePath = "NO_IMAGE")
        {
            bool condition = false;
            //Call method AddUser to insert information in the users table
            bool flag = AddUser(firstName, lastName, middleName, email, address, contactNum, (int)UserLevel.Teacher, imagePath);

            //Checks if add User is successful
            if (!flag)
            {
                return condition;
            }

            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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
                        return condition;
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
                            condition = true;
                        }
                        else
                        {
                            condition = false;
                        }
                    }

                }
                catch (Exception ex)
                {
                    condition |= false;
                }
                finally { connection.Close(); }
            }
            return condition;
        }
        public static List<string> AddStudentByExcel(string fileLocation, string workSheetLocation, int startRow)
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
                                .Skip(startRow)  // Skip header rows
                                .Any(cell => cell.Start.Column == col && cell.Value != null);

                            if (columnHasData)
                            {
                                actualColumnCount++;
                            }
                        }

                        // Check if the number of columns is as expected
                        if (actualColumnCount != 13)
                        {
                            errors.Add($"Expected {13} columns, but found {actualColumnCount} columns.");
                            return errors;
                        }

                        // Adjust actualRowCount based on the presence of header
                        //Iterate through the rows and columns
                        for (int row = 1; row <= (startRow - 2) + actualRowCount; row++)
                        {
                            if (row < startRow) continue; //skips the rows above the header
                            string[] colValues = new string[13]; //Store info here
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
                                // Check the header
                                IdentificationResult result = IdentifyStudentColumnInfoSequence(worksheet, startRow);
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
                            }
                            //Check if all infos provided is valid
                            var validateResult = CheckStudentInfoFromExcel(colValues);
                            if (validateResult.isValid)
                            {
                                string address = colValues[(int)StudentInfo.BlockNo] + ", " + colValues[(int)StudentInfo.Street] + ", " +
                                    colValues[(int)StudentInfo.Barangay] + ", " + colValues[(int)StudentInfo.City];

                                if (string.IsNullOrEmpty(colValues[(int)StudentInfo.ImagePath]) ||
                                    colValues[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NO_IMAGE" ||
                                    colValues[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NO IMAGE" ||
                                    colValues[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NO-IMAGE" ||
                                    colValues[(int)StudentInfo.ImagePath].ToUpper().Trim() == "NOIMAGE" ||
                                    colValues[(int)StudentInfo.ImagePath].ToUpper().Trim() == "N/A")
                                {

                                    AddStudent(
                                        colValues[(int)StudentInfo.FirstName].Trim(),
                                        colValues[(int)StudentInfo.LastName].Trim(),
                                        colValues[(int)StudentInfo.MiddleInitial].ToUpper().Trim().Trim('.'),
                                        colValues[(int)StudentInfo.Email].Trim(),
                                        address.Trim(),
                                        colValues[(int)StudentInfo.ContactNum].Trim(),
                                        colValues[(int)StudentInfo.Department].Trim(),
                                        int.Parse(colValues[(int)StudentInfo.YearLevel]),
                                        colValues[(int)StudentInfo.Section].Trim()
                                        );
                                }
                                else
                                {
                                    AddStudent(
                                        colValues[(int)StudentInfo.FirstName].Trim(),
                                        colValues[(int)StudentInfo.LastName].Trim(),
                                        colValues[(int)StudentInfo.MiddleInitial].ToUpper().Trim().Trim('.'),
                                        colValues[(int)StudentInfo.Email].Trim(),
                                        address,
                                        colValues[(int)StudentInfo.ContactNum].Trim(),
                                        colValues[(int)StudentInfo.Department].Trim(),
                                        int.Parse(colValues[(int)StudentInfo.YearLevel]),
                                        colValues[(int)StudentInfo.Section].Trim(),
                                        colValues[(int)StudentInfo.ImagePath].Trim()
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
        public static List<string> AddTeacherByExcel(string fileLocation, string workSheetLocation, int startRow)
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
                                .Skip(startRow)  // Skip header rows
                                .Any(cell => cell.Start.Column == col && cell.Value != null);

                            if (columnHasData)
                            {
                                actualColumnCount++;
                            }
                        }

                        // Check if the number of columns is as expected
                        if (actualColumnCount != 11)
                        {
                            errors.Add($"Expected {11} columns, but found {actualColumnCount} columns.");
                            return errors;
                        }

                        // Adjust actualRowCount based on the presence of header
                        //Iterate through the rows and columns
                        for (int row = startRow; row <= (startRow - 2) + actualRowCount; row++)
                        {
                            if (row < startRow) continue; //skips the rows above the header
                            string[] colValues = new string[11]; //Store info here
                            //Iterate through columns
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
                                // Check the header
                                IdentificationResult result = IdentifyTeacherColumnInfoSequence(worksheet, startRow);
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
                            }
                            //Check if all infos provided is valid
                            var validateResult = CheckTeacherInfoFromExcel(colValues);
                            if (validateResult.isValid)
                            {
                                string address = colValues[(int)TeacherInfo.BlockNo] + ", " + colValues[(int)TeacherInfo.Street] + ", " +
                                    colValues[(int)TeacherInfo.Barangay] + ", " + colValues[(int)TeacherInfo.City];

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
                                            colValues[(int)TeacherInfo.MiddleInitial].ToUpper().Trim().Trim('.'),
                                            colValues[(int)TeacherInfo.Email],
                                            address,
                                            colValues[(int)TeacherInfo.ContactNum],
                                            colValues[(int)TeacherInfo.Department]
                                        );
                                }
                                else
                                {
                                    AddTeacher(
                                            colValues[(int)TeacherInfo.FirstName],
                                            colValues[(int)TeacherInfo.LastName],
                                            colValues[(int)TeacherInfo.MiddleInitial].ToUpper().Trim().Trim('.'),
                                            colValues[(int)TeacherInfo.Email],
                                            address,
                                            colValues[(int)TeacherInfo.ContactNum],
                                            colValues[(int)TeacherInfo.Department],
                                            colValues[(int)TeacherInfo.ImagePath]
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
        //USER CREATION IN THE APP - LOGIN
        public static object Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
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
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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
        public static bool UpdateStudentInformation(int studentUserId, string newDepartment, int newYearLevel, string newSection, string firstName, string lastName, string middleName, string address, string contactNumber, string imagePath)
        {
            bool condition = false;
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();

                string updateQuery = @"UPDATE students
                                   SET department = @NewDepartment,
                                       year_level = @NewYearLevel,
                                       section = @NewSection
                                   WHERE user_id = @StudentId";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {
                    if (UpdateUserInformation(studentUserId, firstName, lastName, middleName, address, contactNumber, imagePath))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", studentUserId);
                        cmd.Parameters.AddWithValue("@NewDepartment", newDepartment);
                        cmd.Parameters.AddWithValue("@NewYearLevel", newYearLevel);
                        cmd.Parameters.AddWithValue("@NewSection", newSection);


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            condition = true;
                        }
                        else
                        {
                            condition = false;
                        }
                    }

                }
            }
            return condition;
        }
        public static bool UpdateTeacherInformation(int teacherUserId, string newDepartment, string firstName, string lastName, string middleName, string address, string contactNumber, string imagePath)
        {
            bool condition = false;
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();

                string updateQuery = @"UPDATE teachers
                                   SET department = @NewDepartment
                                   WHERE user_id = @user_Id";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {
                    if (UpdateUserInformation(teacherUserId, firstName, lastName, middleName, address, contactNumber, imagePath))
                    {
                        cmd.Parameters.AddWithValue("@user_Id", teacherUserId);
                        cmd.Parameters.AddWithValue("@NewDepartment", newDepartment);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            condition = true;
                        }
                        else
                        {
                            condition = false;
                        }
                    }
                }
            }
            return condition;
        }
        public static bool UpdateUserInformation(int userId, string firstName, string lastName, string middleName, string address, string contactNumber, string imagePath)
        {
            bool condition = false;
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
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
                    cmd.Parameters.AddWithValue("@MiddleName", middleName.ToUpper().Trim('.').Trim());
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("@ImagePath", imagePath);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        condition = true;
                    }
                    else
                    {
                        condition = false;
                    }
                }
            }
            return condition;
        }
        public static void UpdateUserStatus(int userId, string newStatus)
        {
            using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                connection.Open();

                string query = "UPDATE users SET status = @newStatus WHERE id = @userId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newStatus", newStatus);
                    command.Parameters.AddWithValue("@userId", userId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static bool UpdatePassword(string userId, string newPassword)
        {
            bool isAdmin = userId.StartsWith("AA", StringComparison.OrdinalIgnoreCase);
            bool isEmployee = userId.StartsWith("AE", StringComparison.OrdinalIgnoreCase);

            if (isAdmin || isEmployee)
            {
                string tableName = isAdmin ? "admin" : "employee";
                string idColumnName = isAdmin ? "admin_id" : "employee_id";

                using (MySqlConnection connection = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
                {
                    connection.Open();

                    string query = $"UPDATE {tableName} SET password = @newPassword WHERE {idColumnName} = @userId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@newPassword", newPassword);
                        command.Parameters.AddWithValue("@userId", userId);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0; // Returns true if the password was updated
                    }
                }
            }

            return false; // Or throw an exception, depending on your requirements
        }
        #endregion

    }
}
