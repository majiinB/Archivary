using Archivary._900X500;
using Archivary.BACKEND.OBJECTS;
using Archivary.BACKEND.USER_OPERATIONS;
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
    public partial class FORM_EDITTEACHER : Form
    {
        private string selectedFilePath;
        private Teacher userTeacher;
        private FORM_ALERT alert;

        public FORM_EDITTEACHER(Teacher teacher)
        {
            InitializeComponent();
            ShowInTaskbar = false;
            this.userTeacher = teacher;
            lastNameTextBox.Text = teacher.TeacherLastName;
            firstNameTextBox.Text = teacher.TeacherFirstName;
            middleInitialTextBox.Text = teacher.TeacherMiddleName;
            emailTextBox.Text = teacher.TeacherEmail;
            contactNumberTextBox.Text = teacher.TeacherContactNum;
            string[] address = UserOperation.SplitAddress(teacher.TeacherAddress);
            houseNumberTextBox.Text = address[0];
            streetTextBox.Text = address[1];
            barangayTextBox.Text = address[2];
            cityTextBox.Text = address[3];
            SetPictureBoxImage(teacher.TeacherImagePath);
            selectedFilePath = teacher.TeacherImagePath;   
        }
        private void DrawCustomBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth)
        {
            ControlPaint.DrawBorder(graphics, rectangle, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid);
        }
        private void FORM_EDITTEACHER_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(37, 211, 102), 3);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                profilePictureImageBox.SizeMode = PictureBoxSizeMode.Zoom;
                profilePictureImageBox.Size = image.Size;
            }
            catch (System.IO.FileNotFoundException)
            {
                // Handle the case when the file is not found
                // Load a default image from resources and set it to the PictureBox
                profilePictureImageBox.Image = Properties.Resources.PLACEHOLDER_PICTURE;

                // Optionally, adjust the PictureBox size to fit the default image
                profilePictureImageBox.SizeMode = PictureBoxSizeMode.Zoom;
                profilePictureImageBox.Size = Properties.Resources.PLACEHOLDER_PICTURE.Size;
            }
            catch (Exception ex)
            {
                alert = new FORM_ALERT(1, "IMAGE LOAD ERROR", $"Error loading image: {ex.Message}");
                alert.ShowDialog();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Concat the each textbox for adress
            string concatAddress = houseNumberTextBox.Text + ", " + streetTextBox.Text + ", "
                + barangayTextBox.Text + ", " + cityTextBox.Text;

            if (firstNameTextBox.Text != userTeacher.TeacherFirstName || lastNameTextBox.Text != userTeacher.TeacherLastName ||
                middleInitialTextBox.Text != userTeacher.TeacherMiddleName || emailTextBox.Text != userTeacher.TeacherEmail ||
                concatAddress != userTeacher.TeacherAddress || contactNumberTextBox.Text != userTeacher.TeacherContactNum ||
                selectedFilePath != userTeacher.TeacherImagePath || collegeTextBox.Text != userTeacher.TeacherDepartment
                )
            {
                //Condition to bypass the userinput valid if the user still doesnt want an image
                string conditionImage = (selectedFilePath == "NO_IMAGE") ? "No_image" : selectedFilePath;
                //Condition to bypass the userinput valid if the user still doesnt to change email
                string conditionEmail = (emailTextBox.Text == userTeacher.TeacherEmail) ? UserOperation.GeneratePassword() + "@gmail.com" : emailTextBox.Text;
                //Check user input, returns array of string which contains the message
                string[] errorMessage = UserOperation.IsUserInputValid(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    middleInitialTextBox.Text,
                    conditionEmail,
                    concatAddress,
                    contactNumberTextBox.Text,
                    conditionImage,
                    collegeTextBox.Text
                    );

                //Check address one by one kingina di pala to iisang texbox
                if (string.IsNullOrEmpty(houseNumberTextBox.Text) || string.IsNullOrEmpty(streetTextBox.Text) ||
                    string.IsNullOrEmpty(barangayTextBox.Text) || string.IsNullOrEmpty(cityTextBox.Text))
                {
                    alert = new FORM_ALERT(1, "INVALID ADDRESS INPUT", "One of the textbox for address is empty");
                    alert.ShowDialog();
                    return;
                }

                //If the errormessage array length is 0 continue to Update
                if (errorMessage.Length == 0)
                {
                    //Update user information function that returns true if successful
                    if (UserOperation.UpdateTeacherInformation(
                        userTeacher.TeacherUserId,
                        collegeTextBox.Text,
                        firstNameTextBox.Text,
                        lastNameTextBox.Text,
                        middleInitialTextBox.Text,
                        concatAddress,
                        contactNumberTextBox.Text,
                        selectedFilePath
                        ))
                    {
                        UpdateTeacherObject(concatAddress); // Update the object referenced
                        alert = new FORM_ALERT(3, "TEACHER INFO UPDATE SUCCESS", "");
                        alert.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    //Error message for input validation
                    alert = new FORM_ALERT(1, "TEACHER INFO UPDATE FAILED", "An error has occured during the update process");
                    alert.ShowDialog();
                }

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

        private void UpdateTeacherObject(string concatAddress)
        {
            userTeacher.TeacherFirstName = firstNameTextBox.Text;
            userTeacher.TeacherLastName = lastNameTextBox.Text;
            userTeacher.TeacherMiddleName = middleInitialTextBox.Text;
            userTeacher.TeacherAddress = concatAddress;
            userTeacher.TeacherContactNum = contactNumberTextBox.Text;
            userTeacher.TeacherImagePath = selectedFilePath;
            userTeacher.TeacherDepartment = collegeTextBox.Text;
        }
    }
   

}
