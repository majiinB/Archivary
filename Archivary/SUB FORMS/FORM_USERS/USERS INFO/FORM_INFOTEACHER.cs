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

namespace Archivary._1500X1000.FORM_USERS
{
    public partial class FORM_INFOTEACHER : Form
    {
        private FORM_EDITTEACHER editInfo;
        private Teacher userTeacher;
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

        public FORM_INFOTEACHER(Teacher teacher)
        {
            InitializeComponent();
            this.userTeacher = teacher;
            InitializeTeacherInfo();
            editInfo = new FORM_EDITTEACHER(teacher);
        }
        

        private void FORM_INFOTEACHER_Load(object sender, EventArgs e)
        {
            loadHistory();
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
        private void editInfoButton_Click(object sender, EventArgs e)
        {
            editInfo.ShowDialog();
            InitializeTeacherInfo();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void statusColor(String status)
        {
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
        private void InitializeTeacherInfo()
        {
            userIDLabel.Text = userTeacher.TeacherId;
            lastNameLabel.Text = userTeacher.TeacherLastName;
            firstNameLabel.Text = userTeacher.TeacherFirstName;
            //Set the middle initial to blank if N/A
            string middleInitial = (userTeacher.TeacherMiddleName == "N/A") ? "" : userTeacher.TeacherMiddleName;
            middleNameLabel.Text = middleInitial;
            collegeLabel.Text = userTeacher.TeacherDepartment;
            emailLabel.Text = userTeacher.TeacherEmail;
            contactNumLabel.Text = userTeacher.TeacherContactNum;
            //Trim the start of the address if N/A
            string originalAddress = userTeacher.TeacherAddress;
            string substringToRemove = "N/A,";
            string trimmedAddress = originalAddress.StartsWith(substringToRemove)
                ? originalAddress.Substring(substringToRemove.Length).TrimStart()
                : originalAddress;
            addressLabel.Text = trimmedAddress;
            statusColor(userTeacher.TeacherStatus);
            SetPictureBoxImage(userTeacher.TeacherImagePath);
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
            if (userTeacher.TeacherStatus == "ACTIVE")
            {
                UserOperation.UpdateUserStatus(userTeacher.TeacherUserId, "INACTIVE");
                statusColor("INACTIVE");
                userTeacher.TeacherStatus = "INACTIVE";
            }
            else
            {
                UserOperation.UpdateUserStatus(userTeacher.TeacherUserId, "ACTIVE");
                statusColor("ACTIVE");
                userTeacher.TeacherStatus = "ACTIVE";
            }
        }

        private void loadHistory()
        {

            Setting day = CommonOperation.GetSettingsFromDatabase();
            bookStatusList = UserOperation.GetBookStatusList(userTeacher.TeacherUserId, day.borrowingDuration);

            foreach (BookStatusInfo bookStatus in bookStatusList)
            {
                string returnDate = "";

                // Check if the ReturnDate is the default DateTime value
                if (bookStatus.ReturnDate == DateTime.MinValue)
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
