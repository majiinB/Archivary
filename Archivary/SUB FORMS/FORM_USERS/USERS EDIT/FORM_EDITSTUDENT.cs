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
    public partial class FORM_EDITSTUDENT : Form
    {
        private string selectedFilePath;
        private Student userStudent;
        public FORM_EDITSTUDENT(Student student)
        {
            InitializeComponent();
            ShowInTaskbar = false;
            this.userStudent = student;
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
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //Concat the each textbox for adress
            string concatAddress = houseNumberTextBox.Text + ", " + streetTextBox.Text + ", "
                + barangayTextBox.Text + ", " + cityTextBox.Text;

            //Check if any info has changed
            if (firstNameTextBox.Text != userStudent.StudentFirstName || lastNameTextBox.Text != userStudent.StudentLastName ||
                middleInitialTextBox.Text != userStudent.StudentMiddleName || emailTextBox.Text != userStudent.StudentEmail ||
                concatAddress != userStudent.StudentAddress || contactNumberTextBox.Text != userStudent.StudentContactNum ||
                selectedFilePath != userStudent.StudentImagePath || collegeTextBox.Text != userStudent.StudentDepartment ||
                yearTextBox.Text != userStudent.StudentYearLevel.ToString() || sectionTextBox.Text != userStudent.StudentSection
                )
            {
                //Condition to bypass the userinput valid if the user still doesnt want an image
                string conditionImage = (selectedFilePath == "NO_IMAGE") ? "No_image" : selectedFilePath;
                //Condition to bypass the userinput valid if the user still doesnt to change email
                string conditionEmail = (emailTextBox.Text == userStudent.StudentEmail) ? UserOperation.GeneratePassword() + "@gmail.com" : emailTextBox.Text;
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
                    MessageBox.Show("Invalid Input For Address\nOne of the textbox for address is empty");
                    return;
                }

                //If the errormessage array length is 0 continue to Update
                if (errorMessage.Length == 0) 
                {
                    //Update user information function that returns true if successful
                    if (UserOperation.UpdateStudentInformation(
                        userStudent.StudentUserId,
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
                        MessageBox.Show("Student Info Update Successful");
                        this.Close();
                    }
                    else
                    {
                        //Error message for update
                        MessageBox.Show("Update failed");
                    }
                }
                else
                {
                    //Error message for input validation
                    MessageBox.Show(errorMessage[0] + "\n" + errorMessage[1]);
                }
            }

        }
        private void UpdateStudentObject(string concatAddress)
        {
            userStudent.StudentFirstName = firstNameTextBox.Text;
            userStudent.StudentLastName = lastNameTextBox.Text;
            userStudent.StudentMiddleName = middleInitialTextBox.Text;
            userStudent.StudentAddress = concatAddress;
            userStudent.StudentContactNum = contactNumberTextBox.Text;
            userStudent.StudentImagePath = selectedFilePath;
            userStudent.StudentDepartment = collegeTextBox.Text;
            userStudent.StudentSection = sectionTextBox.Text;
            userStudent.StudentYearLevel = int.Parse(yearTextBox.Text);
        }
    }
    
}
