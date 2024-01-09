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
using Archivary._900X500;
using Archivary.BACKEND.COMMON_OPERATIONS;
using Archivary.BACKEND.OBJECTS;
using Archivary.BACKEND.USER_OPERATIONS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Archivary._1500X1000.FORM_USERS
{
    public partial class FORM_INFOSTUDENT : Form
    {
        private FORM_EDITSTUDENT editInfo;
        private Student userStudent;
        private FORM_ALERT alert;
        List<BookStatusInfo> bookStatusList;
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
            this.userStudent = student;
            IntializeStudentInfo();
            editInfo = new FORM_EDITSTUDENT(student);
        }


        private void FORM_INFOSTUDENT_Load(object sender, EventArgs e)
        {
            loadHistory();
        }
        
        private void backButton_Click(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void editInfoButton_Click(object sender, EventArgs e)
        {
            editInfo.ShowDialog();
            IntializeStudentInfo();
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

        #region BACKEND
        private void IntializeStudentInfo()
        {
            userIDLabel.Text = userStudent.StudentId;
            lastNameLabel.Text = userStudent.StudentLastName;
            firstNameLabel.Text = userStudent.StudentFirstName;
            //Set the middle initial to blank if N/A
            string middleInitial = (userStudent.StudentMiddleName == "N/A") ? "" : userStudent.StudentMiddleName;
            middleNameLabel.Text = middleInitial;
            emailLabel.Text = userStudent.StudentEmail;
            contactNumLabel.Text = userStudent.StudentContactNum;
            //Trim the start of the address if N/A
            string originalAddress = userStudent.StudentAddress; ;
            string substringToRemove = "N/A,";
            string trimmedAddress = originalAddress.StartsWith(substringToRemove)
                ? originalAddress.Substring(substringToRemove.Length).TrimStart()
                : originalAddress;
            addressLabel.Text = trimmedAddress;
            statusColor(userStudent.StudentStatus);
            collegeLabel.Text = userStudent.StudentDepartment;
            sectionLabel.Text = userStudent.StudentYearLevel + " " + userStudent.StudentSection;
            SetPictureBoxImage(userStudent.StudentImagePath);
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
                alert = new FORM_ALERT(1, "LOAD IMAGE ERROR", $"Error loading image: {ex.Message}");
                alert.ShowDialog();
            }
        }

        private void changeStatusButton_Click(object sender, EventArgs e)
        {
            if (userStudent.StudentStatus == "ACTIVE")
            {
                UserOperation.UpdateUserStatus(userStudent.StudentUserId, "INACTIVE");
                statusColor("INACTIVE");
                userStudent.StudentStatus = "INACTIVE";
            }
            else
            {
                UserOperation.UpdateUserStatus(userStudent.StudentUserId, "ACTIVE");
                statusColor("ACTIVE");
                userStudent.StudentStatus = "ACTIVE";
            }
        }

        private async Task loadHistory()
        {
            await Task.Run(() =>
            {
                Setting day = CommonOperation.GetSettingsFromDatabase();
                bookStatusList = UserOperation.GetBookStatusList(userStudent.StudentUserId, day.borrowingDuration);
            });

            foreach (BookStatusInfo bookStatus in bookStatusList)
            {
                string returnDate = "";
                if (bookStatus.ReturnDate.ToString() == CommonOperation.TimeFormatsArray[(int)CommonOperation.TimeFormats.DateTimeMin])
                {
                    returnDate = CommonOperation.TimeFormatsArray[(int)CommonOperation.TimeFormats.IfNotReturnedStatus];
                }
                else
                {
                    returnDate = CommonOperation.ConvertToReadableFormat(
                        bookStatus.ReturnDate.ToString(
                            CommonOperation.TimeFormatsArray[(int)CommonOperation.TimeFormats.YearMontDate]
                            )
                        );
                }
                bookListDataGridView.Rows.Add(bookStatus.Title, 
                    CommonOperation.ConvertToReadableFormat(bookStatus.BorrowedAt.ToString(CommonOperation.TimeFormatsArray[(int)CommonOperation.TimeFormats.YearMontDate])),
                    CommonOperation.ConvertToReadableFormat(bookStatus.ReturnDueDate.ToString(CommonOperation.TimeFormatsArray[(int)CommonOperation.TimeFormats.YearMontDate])),
                    returnDate, bookStatus.Status);
            }
        }
        #endregion
    }
}
