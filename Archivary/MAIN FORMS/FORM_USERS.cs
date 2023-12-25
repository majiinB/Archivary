using CustomDropdown;
using Archivary._1500X1000.FORM_USERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Archivary._1500X1000.FORM_LIBRARY;
using Archivary._1200X800.FORM_USERS;
using Archivary.BACKEND.USER_OPERATIONS;
using System.Collections;
using Archivary.BACKEND.BOOK_OPERATIONS;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using Archivary.BACKEND.OBJECTS;

namespace Archivary.PARENT_FORMS
{
    public partial class FORM_USERS : Form
    {

        private FORM_INFOEMPLOYEE employeeInfo;
        private FORM_INFOTEACHER teacherInfo;
        private FORM_INFOSTUDENT studentInfo;
        private FORM_SIGNUP FormsSignup = new FORM_SIGNUP();
        private ArrayList students;
        private ArrayList teachers;
        private ArrayList employees;
        private ArrayList users;
        private object user;
        private string filter = "All";
        private string searchKey = "";
        //
        // COLOR METHODS
        //
        private Color archivaryGreen()
        {
            return Color.FromArgb(37, 211, 102);
        }

        private Color archivaryWhite()
        {
            return Color.FromArgb(244, 244, 244);
        }

        private Color archivaryCream()
        {
            return Color.FromArgb(208, 190, 143);
        }

        private Color archivaryRed()
        {
            return Color.FromArgb(227, 25, 55);
        }
        private Color archivaryHoverGray()
        {
            return Color.FromArgb(200, 200, 200);
        }

        //MAIN
        public FORM_USERS(object user)
        {
            InitializeComponent();

            //Assign the one who logged in as user to access info form different methods
            this.user = user;

            //If user is an employee remove the employee strip menu
            if(user is Employee)
            {
                filterDropdown.Items.Remove(employeeToolStripMenuItem);
            }
        }

        private void FORM_USERS_Load(object sender, EventArgs e)
        {
            dropdownProperties();
            SearchUsers(searchKey);
        }   

        private void FORM_USERS_Resize(object sender, EventArgs e)
        {

        }

        private void dropdownProperties()
        {
            filterDropdown.IsMainMenu = true;
            filterDropdown.PrimaryColor = archivaryGreen();
        }

        private void openDropdownMenu(DropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            //dropdownMenu.Show(control, control.Width - dropdownMenu.Width, control.Height);
            dropdownMenu.Show(control, control.Width - control.Width, control.Height);
        }

        private void filterSearchButton_Click(object sender, EventArgs e)
        {
            openDropdownMenu(filterDropdown, sender);
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text == "Search User")
            {
                searchBar.Text = "";
                searchBar.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
                searchBar.ForeColor = archivaryWhite();
            }
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (searchBar.Text == "")
            {
                searchBar.Text = "Search User";
                searchBar.ForeColor = archivaryHoverGray();
                searchBar.Font = new Font("Montserrat Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            }
        }

        //
        // DROPDOWN EVENTS
        //
        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "All";
            filter = filterSearchButton.Text;
            SearchUsers(searchKey);
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Student";
            filter = filterSearchButton.Text;
            SearchUsers(searchKey);
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Teacher";
            filter = filterSearchButton.Text;
            SearchUsers(searchKey);
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user is Admin)
            {
                filterSearchButton.Text = "Employee";
                filter = filterSearchButton.Text;
                SearchUsers(searchKey);
            }
            else return; 
        }

        //
        //change forecolor depending on status
        //
        private void userDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*foreach (DataGridViewRow row in userDataGridView.Rows)
           {
                string status = Convert.ToString(row.Cells[3].Value).ToLower();
                string role = Convert.ToString(row.Cells[2].Value).ToLower();

                if (role == "teacher") row.Cells[2].Style.ForeColor = archivaryCream();
                else if (role == "student") row.Cells[2].Style.ForeColor = archivaryCream();
                else if (role == "employee") row.Cells[2].Style.ForeColor = archivaryCream();

                if (status == "deactivated") row.Cells[3].Style.ForeColor = archivaryRed();
                else if (status == "activate") row.Cells[3].Style.ForeColor = archivaryGreen();
           }*/
        }

        private void userDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i <= e.RowIndex + e.RowCount - 1; i++)
            {
                var row = userDataGridView.Rows[i];
                string status = Convert.ToString(row.Cells[3].Value).ToUpper();

                if (status == null) continue;
 
                if (status == "INACTIVE") row.Cells[3].Style.ForeColor = archivaryRed();
                else if (status == "ACTIVE") row.Cells[3].Style.ForeColor = archivaryGreen();
            }
        }

        private void userDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the double-click is on a valid cell (not a header or empty space)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int i = 0;
                string[] cellInfo = new string[4];
                // Get the data from the clicked row
                DataGridViewRow clickedRow = userDataGridView.Rows[e.RowIndex];

                // Access the data in each cell of the clicked row
                foreach (DataGridViewCell cell in clickedRow.Cells)
                {
                    object cellValue = cell.Value;
                    if (cellValue is string stringVal)
                    {
                        cellInfo[i] = stringVal;
                    }
                    i++;
                }

                if (cellInfo[2] == "Employee")
                {
                    Employee employee = UserOperation.GetEmployeeByEmployeeId(cellInfo[1]);
                    if(employee != null)
                    {
                        employeeInfo = new FORM_INFOEMPLOYEE(employee);
                        employeeInfo.ShowDialog();
                        SearchUsers(searchKey);
                    }
                }
                else if (cellInfo[2] == "Teacher")
                {
                    Teacher teacher = UserOperation.GetTeacherById(cellInfo[1]);
                    if(teacher != null)
                    {
                        teacherInfo = new FORM_INFOTEACHER(teacher);
                        teacherInfo.ShowDialog();
                        SearchUsers(searchKey);
                    }
                }
                else if (cellInfo[2] == "Student")
                {
                    Student student = UserOperation.GetStudentById(cellInfo[1]);
                    if(student != null)
                    {
                        studentInfo = new FORM_INFOSTUDENT(student);
                        studentInfo.ShowDialog();
                        SearchUsers(searchKey);
                    }
                }
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            FormsSignup.ShowDialog();
            SearchUsers(searchKey);
        }

        #region SEARCH FUNCTION
        //TEXT CHANGED ACTION LISTENER
        private void Search(object sender, EventArgs e)
        {
            searchKey = searchBar.Text;
            SearchUsers(searchKey);
        }
        //Search method
        public ArrayList SearchUsers(string searchString)
        {
            userDataGridView.Rows.Clear();
            LoadUsersToList();
            ArrayList searchResults = new ArrayList();
            if (users.Count > 0)
            {
                foreach (string[] user in users)
                {
                    if (string.IsNullOrEmpty(searchString) || searchString == "Search User")
                    {
                        string[] nextUser = (string[])user;
                        userDataGridView.Rows.Add(nextUser[0] + ", " + nextUser[1] + " " + nextUser[2], nextUser[3], nextUser[4], nextUser[5]);
                    }
                    else if (!string.IsNullOrEmpty(searchString))
                    {
                        // Perform case-insensitive search
                        if (ContainsIgnoreCase(user, searchString))
                        {
                            string[] nextUser = (string[])user;
                            userDataGridView.Rows.Add(nextUser[0] + ", " + nextUser[1] + " " + nextUser[2], nextUser[3], nextUser[4], nextUser[5]);
                        }
                    }
                }
            }
            return searchResults;
        }
        //Helper function to check if an array contains a substring (case-insensitive)
        public bool ContainsIgnoreCase(string[] array, string searchString)
        {
            foreach (string item in array)
            {
                if (item.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return true;
                }
            }

            return false;
        }
        //Method that chooses which users will be loaded
        private void LoadUsersToList()
        {
            users = new ArrayList();
            userDataGridView.Rows.Clear();
            if (filter == "All")
            {
                students = UserOperation.GetAllStudents();
                teachers = UserOperation.GetAllTeachers();
                if(user is Admin)
                {
                    employees = UserOperation.GetAllEmployees();
                    AddUsersToList(employees);
                }

                AddUsersToList(teachers);
                AddUsersToList(students);
            }
            else if (filter == "Student")
            {
                students = UserOperation.GetAllStudents();
                AddUsersToList(students);
            }
            else if (filter == "Teacher")
            {
                teachers = UserOperation.GetAllTeachers();
                AddUsersToList(teachers);
            }
            else if (filter == "Employee")
            {
                if(user is Admin)
                {
                    employees = UserOperation.GetAllEmployees();
                    AddUsersToList(employees);
                }
            }
        }
        //Loads all  kinds of user to the same list
        private void AddUsersToList(ArrayList diffUsers)
        {
            if (diffUsers != null || diffUsers.Count > 0)
            {
                foreach (var diff in diffUsers)
                {
                    string[] info = new string[6];

                    if (diff is Student student)
                    {
                        info[0] = student.StudentLastName;
                        info[1] = student.StudentFirstName;
                        info[2] = student.StudentMiddleName;
                        info[3] = student.StudentId;
                        info[4] = "Student";
                        info[5] = student.StudentStatus;
                    }
                    else if (diff is Employee employee)
                    {
                        
                        info[0] = employee.EmployeeLastName;
                        info[1] = employee.EmployeeFirstName;
                        info[2] = employee.EmployeeMiddleName;
                        info[3] = employee.EmployeeId;
                        info[4] = "Employee";
                        info[5] = employee.EmployeeStatus;
                        
                    }
                    else if (diff is Teacher teacher)
                    {
                        info[0] = teacher.TeacherLastName;
                        info[1] = teacher.TeacherFirstName;
                        info[2] = teacher.TeacherMiddleName;
                        info[3] = teacher.TeacherId;
                        info[4] = "Teacher";
                        info[5] = teacher.TeacherStatus;
                    }
                    users.Add(info);
                }
            }
        }
        #endregion
    }
}
