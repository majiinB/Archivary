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

        private FORM_INFOEMPLOYEE employeeInfo= new FORM_INFOEMPLOYEE();
        private FORM_INFOTEACHER teacherInfo = new FORM_INFOTEACHER();
        private FORM_INFOSTUDENT studentInfo = new FORM_INFOSTUDENT();
        private FORM_SIGNUP FormsSignup = new FORM_SIGNUP();
        private ArrayList students;
        private ArrayList teachers;
        private ArrayList employees;
        private string filter = "All";
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
        public FORM_USERS()
        {
            InitializeComponent();

        }

        private void FORM_USERS_Load(object sender, EventArgs e)
        {
            dropdownProperties();
            LoadToTable();
        }
        private void LoadToTable()
        {
            userDataGridView.Rows.Clear();
            if(filter == "All")
            {
                students = UserOperation.GetAllStudents();
                teachers = UserOperation.GetAllTeachers();
                employees = UserOperation.GetAllEmployees();

                IterateThroughElements(employees);
                IterateThroughElements(teachers);               
                IterateThroughElements(students);
            }
            else if(filter == "Student")
            {
                students = UserOperation.GetAllStudents();
                IterateThroughElements(students);
            }else if(filter == "Teacher")
            {
                teachers = UserOperation.GetAllTeachers();
                IterateThroughElements(teachers);
            }else if(filter == "Employee")
            {
                employees = UserOperation.GetAllEmployees();
                IterateThroughElements(employees);
            }
        }
        private void IterateThroughElements(ArrayList usersList)
        {
            foreach (var user in usersList)
            {
                if(user is Student student) 
                {
                    userDataGridView.Rows.Add(student.StudentLastName + ", " + student.StudentFirstName + " " + student.StudentMiddleName, student.StudentId, "Student", student.StudentStatus);
                }
                else if(user is Employee employee)
                {
                    userDataGridView.Rows.Add(employee.EmployeeLastName + ", " + employee.EmployeeFirstName + " " + employee.EmployeeMiddleName, employee.EmployeeId, "Employee", employee.EmployeeStatus);
                }
                else if(user is Teacher teacher)
                {
                    userDataGridView.Rows.Add(teacher.TeacherLastName + ", " + teacher.TeacherFirstName + " " + teacher.TeacherMiddleName, teacher.TeacherId, "Teacher", teacher.TeacherStatus);
                }
            }
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
            LoadToTable();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Student";
            filter = filterSearchButton.Text;
            LoadToTable();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Teacher";
            filter = filterSearchButton.Text;
            LoadToTable();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Employee";
            filter = filterSearchButton.Text;
            LoadToTable();
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
                string status = Convert.ToString(row.Cells[3].Value).ToLower();

                if (status == null) continue;
 
                if (status == "deactivated") row.Cells[3].Style.ForeColor = archivaryRed();
                else if (status == "active") row.Cells[3].Style.ForeColor = archivaryGreen();
            }
        }

        private void userDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            teacherInfo.ShowDialog();
            studentInfo.ShowDialog();
            employeeInfo.ShowDialog();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            FormsSignup.ShowDialog();

        }


    }
}
