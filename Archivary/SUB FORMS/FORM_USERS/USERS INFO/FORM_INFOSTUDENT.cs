using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivary._1200X800.FORM_USERS;
using Archivary.BACKEND.OBJECTS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Archivary._1500X1000.FORM_USERS
{
    public partial class FORM_INFOSTUDENT : Form
    {
        private FORM_EDITSTUDENT editInfo = new FORM_EDITSTUDENT();
        private Color archivaryGreen()
        {
            return Color.FromArgb(37, 211, 102);
        }

        private Color archivaryRed()
        {
            return Color.FromArgb(237, 41, 57);
        }
        private Color archivaryWhite()
        {
            return Color.FromArgb(244, 244, 244);
        }
        private Color archivaryBlack()
        {
            return Color.FromArgb(20, 18, 18);
        }
        public FORM_INFOSTUDENT(Student student)
        {
            InitializeComponent();
            userIDLabel.Text = student.StudentId;
            lastNameLabel.Text = student.StudentLastName;
            firstNameLabel.Text = student.StudentFirstName;
            middleNameLabel.Text = student.StudentMiddleName;
            emailLabel.Text = student.StudentEmail;
            contactNumLabel.Text = student.StudentContactNum;
            addressLabel.Text = student.StudentAddress;
            statusColor(student.StudentStatus);
            collegeLabel.Text = student.StudentDepartment;
            sectionLabel.Text = student.StudentSection;
            SetPictureBoxImage(student.StudentImagePath);
        }

        private void FORM_INFOSTUDENT_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] returnStatus = { "Overdue", "Not Overdue" };
            String randomStatus;
            int n = 10;
            for (int i = 0; i <= n; i++)
            {
                randomStatus = returnStatus[random.Next(returnStatus.Length)];
                bookListDataGridView.Rows.Add("abcdefghijklmnopqrstuvwxyz", "MM/DD/YY", "MM/DD/YY", "MM/DD/YY", randomStatus);
            }
        }
        private void backButton_Click(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void editInfoButton_Click(object sender, EventArgs e)
        {
            editInfo.ShowDialog();
        }
        private void bookListDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i <= e.RowIndex + e.RowCount - 1; i++)
            {
                var row = bookListDataGridView.Rows[i];
                string returnStatus = Convert.ToString(row.Cells[4].Value).ToLower();
                if (returnStatus == null) continue;

                if (returnStatus == "overdue") row.Cells[4].Style.ForeColor = archivaryRed();
                else if (returnStatus == "not overdue") row.Cells[4].Style.ForeColor = archivaryGreen();
            }
        }

        private void statusColor(String status) {
            if (status == "ACTIVE")
            {
                editInfoButton.BackColor = archivaryGreen();
                editInfoButton.ForeColor = archivaryBlack();
                changeStatusButton.BackColor = archivaryRed();
                changeStatusButton.Text = "DEACTIVATE";
                PANEL_role.BorderColor = archivaryGreen();
                PANEL_role.BackgroundColor = archivaryGreen();
                BackColor = archivaryGreen();
                userIDLabel.ForeColor = archivaryGreen();
            }
            else if (status == "INACTIVE")
            {
                editInfoButton.BackColor = archivaryRed();
                editInfoButton.ForeColor = archivaryWhite();
                changeStatusButton.BackColor = archivaryGreen();
                changeStatusButton.Text = "REACTIVATE";
                PANEL_role.BorderColor = archivaryRed();
                PANEL_role.BackgroundColor = archivaryRed();
                BackColor = archivaryRed();
                userIDLabel.ForeColor = archivaryRed();
            }
        }
        private void SetPictureBoxImage(string imagePath)
        {
            try
            {
                // Load the image from the file
                var image = Image.FromFile(imagePath);

                // Set the image to the PictureBox
                roundedPictureBox1.Image = image;

                // Optionally, adjust the PictureBox size to fit the image
                roundedPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                roundedPictureBox1.Size = image.Size;
            }
            catch (System.IO.FileNotFoundException)
            {
                // Handle the case when the file is not found
                // Load a default image from resources and set it to the PictureBox
                roundedPictureBox1.Image = Properties.Resources.PLACEHOLDER_PICTURE;

                // Optionally, adjust the PictureBox size to fit the default image
                //accountPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                //accountPictureBox.Size = Properties.Resources.PLACEHOLDER_PICTURE.Size;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
