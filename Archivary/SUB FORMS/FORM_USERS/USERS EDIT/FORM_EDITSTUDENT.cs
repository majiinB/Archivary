using Archivary._900X500;
using Archivary.BACKEND.OBJECTS;
using Archivary.BACKEND.TIMER;
using Archivary.BACKEND.USER_OPERATIONS;
using OfficeOpenXml.Packaging.Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary._1200X800.FORM_USERS
{
    public partial class FORM_EDITSTUDENT : Form
    {
        private string selectedFilePath;
        private Student student;
        private FORM_ALERT alert;

        public FORM_EDITSTUDENT(Student student)
        {
            InitializeComponent();
            ShowInTaskbar = false;
            this.student = student;
            InitializeStudentInfo();
        }
        
        private void DrawCustomBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth)
        {
            ControlPaint.DrawBorder(graphics, rectangle, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid);
        }
        private void FORM_EDITSTUDENT_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(37, 211, 102), 3);

        }

        private void editInformationLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            InitializeStudentInfo();
            this.Close();
        }

        #region BACKEND
        private void InitializeStudentInfo()
        {
            lastNameTextBox.Text = student.StudentLastName;
            firstNameTextBox.Text = student.StudentFirstName;
            middleInitialTextBox.Text = student.StudentMiddleName;
            emailTextBox.Text = student.StudentEmail;
            contactNumberTextBox.Text = student.StudentContactNum;
            collegeTextBox.Text = student.StudentDepartment;
            yearTextBox.Text = student.StudentYearLevel.ToString();
            sectionTextBox.Text = student.StudentSection;
            string[] address = UserOperation.SplitAddress(student.StudentAddress);
            houseNumberTextBox.Text = address[0];
            streetTextBox.Text = address[1];
            barangayTextBox.Text = address[2];
            cityTextBox.Text = address[3];
            SetPictureBoxImage(student.StudentImagePath);
            selectedFilePath = student.StudentImagePath;
        }
        private void SetPictureBoxImage(string imagePath)
        {
            try
            {
                // Load the image from the file
                var image = Image.FromFile(imagePath);

                // Set the image to the PictureBox
                profilePictureImageBox.Image = image;

                // Optionally, adjust the PictureBox size to fit the image
                profilePictureImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                profilePictureImageBox.Size = image.Size;
            }
            catch (System.IO.FileNotFoundException)
            {
                // Handle the case when the file is not found
                // Load a default image from resources and set it to the PictureBox
                profilePictureImageBox.Image = Properties.Resources.PLACEHOLDER_PICTURE;

                // Optionally, adjust the PictureBox size to fit the default image
                profilePictureImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                profilePictureImageBox.Size = Properties.Resources.PLACEHOLDER_PICTURE.Size;
            }
            catch (Exception ex)
            {
                alert = new FORM_ALERT(1, "IMAGE LOAD ERROR", $"Error loading image: {ex.Message}");
                alert.ShowDialog();
            }
        }
        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPEG Files|*.jpeg;*.jpg|PNG Files|*.png";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                SetPictureBoxImage(selectedFilePath);
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            TimerOpersys.Start();
            //Concat the each textbox for adress
            string concatAddress = houseNumberTextBox.Text + ", " + streetTextBox.Text + ", "
                + barangayTextBox.Text + ", " + cityTextBox.Text;

            //Check if any info has changed
            if (firstNameTextBox.Text != student.StudentFirstName || lastNameTextBox.Text != student.StudentLastName ||
                middleInitialTextBox.Text != student.StudentMiddleName || emailTextBox.Text != student.StudentEmail ||
                concatAddress != student.StudentAddress || contactNumberTextBox.Text != student.StudentContactNum ||
                selectedFilePath != student.StudentImagePath || collegeTextBox.Text != student.StudentDepartment ||
                yearTextBox.Text != student.StudentYearLevel.ToString() || sectionTextBox.Text != student.StudentSection
                )
            {
                //Condition to bypass the userinput valid if the user still doesnt want an image
                string conditionImage = (selectedFilePath == "NO_IMAGE") ? "No_image" : selectedFilePath;
                //Condition to bypass the userinput valid if the user still doesnt to change email
                string conditionEmail = (emailTextBox.Text == student.StudentEmail) ? UserOperation.GeneratePassword() + "@gmail.com" : emailTextBox.Text;
                //Check user input, returns array of string which contains the message
                string[] errorMessage = UserOperation.IsUserInputValid(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    middleInitialTextBox.Text,
                    conditionEmail,
                    concatAddress,
                    contactNumberTextBox.Text,
                    conditionImage,
                    collegeTextBox.Text,
                    yearTextBox.Text,
                    sectionTextBox.Text
                    );

                //Check address one by one kingina di pala to iisang texbox
                if (string.IsNullOrEmpty(houseNumberTextBox.Text) || string.IsNullOrEmpty(streetTextBox.Text) ||
                    string.IsNullOrEmpty(barangayTextBox.Text) || string.IsNullOrEmpty(cityTextBox.Text))
                {
                    TimerOpersys.Stop();
                    alert = new FORM_ALERT(1, "INVALID ADDRESS INPUT", "One of the textbox for address is empty");
                    alert.ShowDialog();
                    InitializeStudentInfo();
                    return;
                }

                //If the errormessage array length is 0 continue to Update
                if (errorMessage.Length == 0) 
                {
                    //Update user information function that returns true if successful
                    if (UserOperation.UpdateStudentInformation(
                        student.StudentUserId,
                        collegeTextBox.Text,
                        int.Parse(yearTextBox.Text),
                        sectionTextBox.Text,
                        firstNameTextBox.Text,
                        lastNameTextBox.Text,
                        middleInitialTextBox.Text,
                        concatAddress,
                        contactNumberTextBox.Text,
                        selectedFilePath
                        ))
                    {
                        UpdateStudentObject(concatAddress);
                        TimerOpersys.Stop();
                        alert = new FORM_ALERT(3, "STUDENT INFO UPDATE SUCCESS", $"Information of student {firstNameTextBox.Text} is now updated");
                        alert.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        //Error message for update
                        TimerOpersys.Stop();
                        alert = new FORM_ALERT(1, "STUDENT INFO UPDATE FAILED", "An error has occured during the update process");
                        alert.ShowDialog();
                        InitializeStudentInfo();
                    }
                }
                else
                {
                    //Error message for input validation
                    TimerOpersys.Stop();
                    alert = new FORM_ALERT(1, errorMessage[0], errorMessage[1]);
                    alert.ShowDialog();
                    InitializeStudentInfo();
                }
            }
            TimerOpersys.Stop();
            if (TimerOpersys.IsEnabled) TimerOpersys.DisplayElapsedTime();
        }
        private void UpdateStudentObject(string concatAddress)
        {
            student.StudentFirstName = firstNameTextBox.Text;
            student.StudentLastName = lastNameTextBox.Text;
            student.StudentMiddleName = middleInitialTextBox.Text;
            student.StudentAddress = concatAddress;
            student.StudentContactNum = contactNumberTextBox.Text;
            student.StudentImagePath = selectedFilePath;
            student.StudentDepartment = collegeTextBox.Text;
            student.StudentSection = sectionTextBox.Text;
            student.StudentYearLevel = int.Parse(yearTextBox.Text);
        }
        #endregion

        private void removeImageButton_Click(object sender, EventArgs e)
        {

        }

        private void removeImageButton_MouseEnter(object sender, EventArgs e)
        {
            removeImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
        }

        private void removeImageButton_MouseLeave(object sender, EventArgs e)
        {
            removeImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
        }
    }

}
