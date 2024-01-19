using Archivary._900X500;
using Archivary.BACKEND.OBJECTS;
using Archivary.BACKEND.SERVICES;
using Archivary.BACKEND.TIMER;
using Archivary.BACKEND.USER_OPERATIONS;
using custom;
using OfficeOpenXml.Packaging.Ionic.Zlib;
using roundedCorners;
using RoundedCorners;
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
    public partial class FORM_SIGNUP : Form
    {
        private roundedButton currentBtn;
        private int conditionForAdd = (int)UserAdd.Student;
        private int conditionForAddExcell = (int)UserAddExcell.Student;
        private string selectedFilePath = "";
        private FORM_ALERT alert;

        private enum UserAdd
        {
            Student = 0,
            Teacher = 1,
            Employee = 2,
        }
        private enum UserAddExcell
        {
            Student = 3,
            Teacher = 2
        }

        public FORM_SIGNUP(object user)
        {
            InitializeComponent();
            ShowInTaskbar = false;
            ActivateButton(studentButton);
            SetPictureBoxImage("No_image");

            if(user is Employee)
            {
                employeeButton.Visible = false;
                employeeButton.Enabled = false;
            }
        }
        private void DrawCustomBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth)
        {
            ControlPaint.DrawBorder(graphics, rectangle, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid);
        }
        private void FORM_SIGNUP_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(100, 100, 100), 2);//3 represents the border width
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
            this.Close();
        }
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (roundedButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 211, 102);
                currentBtn.ForeColor = Color.FromArgb(30, 30, 30);
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(30, 30, 30);
                currentBtn.BorderSize = 2;
                currentBtn.BorderColor = Color.FromArgb(37, 211, 102);
                currentBtn.ForeColor = Color.FromArgb(37, 211, 102);
            }
        }
        private void studentButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ClearAllTextBoxes(this);
            SetPictureBoxImage("No_image"); //to clear ImageBox when the button is clicked
            conditionForAdd = (int)UserAdd.Student;
            conditionForAddExcell = (int)UserAddExcell.Student;
            //visibility of textboxes and labels 
            collegeLabel.Visible = true;
            collegeTextBox.Visible = true;
            PANEL_CONTENTS.SetColumnSpan(collegeTextBox, 3);
            yearLabel.Visible = true;
            yearTextBox.Visible = true;
            sectionLabel.Visible = true;
            sectionTextBox.Visible = true;
            collegeTextBox.Size = new System.Drawing.Size(398, 38);
            uploadExcelFIleButton.Visible = true;

        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ClearAllTextBoxes(this);
            SetPictureBoxImage("No_image"); //to clear ImageBox when the button is clicked
            conditionForAdd = (int)UserAdd.Teacher;
            conditionForAddExcell = (int)UserAddExcell.Teacher;
            //visibility of textboxes and labels 
            collegeLabel.Visible = true;
            collegeTextBox.Visible = true;
            PANEL_CONTENTS.SetColumnSpan(collegeTextBox, 5);
            yearLabel.Visible = false;
            yearTextBox.Visible = false;
            sectionLabel.Visible = false;
            sectionTextBox.Visible = false;
            collegeTextBox.Size = new System.Drawing.Size(651, 38);
            uploadExcelFIleButton.Visible = true;

        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ClearAllTextBoxes(this);
            SetPictureBoxImage("No_image"); //to clear ImageBox when the button is clicked
            conditionForAdd = (int)UserAdd.Employee;

            //visibility of textboxes and labels 
            collegeLabel.Visible = false;
            collegeTextBox.Visible = false;
            yearLabel.Visible = false;
            yearTextBox.Visible = false;
            sectionLabel.Visible = false;
            sectionTextBox.Visible = false;
            uploadExcelFIleButton.Visible = false;
        }
        private void ClearAllTextBoxes(Control control)
        {
            foreach (Control textBoxes in control.Controls)
            {
                if (textBoxes is RoundedTextBox)
                {
                    ((RoundedTextBox)textBoxes).Text = string.Empty;
                }
                else if (textBoxes.HasChildren)
                {
                    ClearAllTextBoxes(textBoxes);
                }
            }
            SetPictureBoxImage("No_image");
        }

        #region Backend
        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            openFolderDialog.Filter = "JPEG Files|*.jpeg;*.jpg|PNG Files|*.png";

            if (openFolderDialog.ShowDialog(this) == DialogResult.OK)
            { 
                selectedFilePath = openFolderDialog.FileName;
                SetPictureBoxImage(selectedFilePath);
            }
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            TimerOpersys.Start();

            //Concat address
            string address = (houseNumberTextBox.Text + ", " + streetTextBox.Text + ", " + barangayTextBox.Text +
                ", " + cityTextBox.Text);

            //Check address one by one kingina di pala to iisang texbox
            if (string.IsNullOrEmpty(houseNumberTextBox.Text) || string.IsNullOrEmpty(streetTextBox.Text) ||
                string.IsNullOrEmpty(barangayTextBox.Text) || string.IsNullOrEmpty(cityTextBox.Text))
            {
                TimerOpersys.Stop();
                alert = new FORM_ALERT(1, "INVALID ADDRESS INPUT", "One of the textbox for address is empty");
                alert.ShowDialog();
            }

            string imageCon = "";
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                imageCon = "No_image";
            }
            else
            {
                imageCon = selectedFilePath;
            }

            if (conditionForAdd == (int)UserAdd.Student)
            {
                //Check for errors
                string[] errorMessage = UserOperation.IsUserInputValid(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    middleInitialTextBox.Text.ToUpper().Trim(','),
                    emailTextBox.Text,
                    address,
                    contactNumberTextBox.Text,
                    imageCon,
                    collegeTextBox.Text,
                    yearTextBox.Text,
                    sectionTextBox.Text
                    );

                //Execute operation if error message length is 0
                if (errorMessage.Length == 0)
                {
                    if (string.IsNullOrEmpty(selectedFilePath))
                    {
                        if (UserOperation.AddStudent(
                        firstNameTextBox.Text,
                        lastNameTextBox.Text,
                        middleInitialTextBox.Text.ToUpper().Trim(','),
                        emailTextBox.Text,
                        address,
                        contactNumberTextBox.Text,
                        collegeTextBox.Text,
                        int.Parse(yearTextBox.Text),
                        sectionTextBox.Text
                        ))
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(3, "USER SUCCESSFULLY ADDED", "Student: " + lastNameTextBox.Text + " Successfully added!");
                            alert.ShowDialog();
                            ClearAllTextBoxes(this);
                        }
                        else
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(1, "ADD USER UNSUCCESSFULL", "An error has occured causing an unsuccessful transaction");
                            alert.ShowDialog();
                            return;
                        }
                    }
                    else
                    {
                        if (UserOperation.AddStudent(
                        firstNameTextBox.Text,
                        lastNameTextBox.Text,
                        middleInitialTextBox.Text.ToUpper().Trim(','),
                        emailTextBox.Text,
                        address,
                        contactNumberTextBox.Text,
                        collegeTextBox.Text,
                        int.Parse(yearTextBox.Text),
                        sectionTextBox.Text,
                        selectedFilePath
                        ))
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(3, "USER SUCCESSFULLY ADDED", "Student: " + lastNameTextBox.Text + " Successfully added!");
                            alert.ShowDialog();
                            ClearAllTextBoxes(this);
                        }
                        else
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(1, "ADD USER UNSUCCESSFULL", "An error has occured causing an unsuccessful transaction");
                            alert.ShowDialog();
                        }
                    }
                }
                else
                {
                    TimerOpersys.Stop();
                    alert = new FORM_ALERT(1, errorMessage[0], errorMessage[1]);
                    alert.ShowDialog();
                }
            }
            else if (conditionForAdd == (int)UserAdd.Teacher)
            {
                //Check for errors
                string[] errorMessage = UserOperation.IsUserInputValid(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    middleInitialTextBox.Text.ToUpper().Trim(','),
                    emailTextBox.Text,
                    address,
                    contactNumberTextBox.Text,
                    imageCon,
                    collegeTextBox.Text
                    );

                //Execute operation if error message length is 0
                if (errorMessage.Length == 0)
                {
                    if (string.IsNullOrEmpty(selectedFilePath))
                    {
                        if (UserOperation.AddTeacher(
                            firstNameTextBox.Text,
                            lastNameTextBox.Text,
                            middleInitialTextBox.Text.ToUpper().Trim(','),
                            emailTextBox.Text,
                            address,
                            contactNumberTextBox.Text,
                            collegeTextBox.Text
                            ))
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(3, "USER SUCCESSFULLY ADDED", "Teacher: " + lastNameTextBox.Text + " Successfully added!");
                            alert.ShowDialog();
                            ClearAllTextBoxes(this);
                        }
                        else
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(1, "ADD USER UNSUCCESSFULL", "An error has occured causing an unsuccessful transaction");
                            alert.ShowDialog();
                        }
                    }
                    else
                    {
                        if (UserOperation.AddTeacher(
                            firstNameTextBox.Text,
                            lastNameTextBox.Text,
                            middleInitialTextBox.Text.ToUpper().Trim(','),
                            emailTextBox.Text,
                            address,
                            contactNumberTextBox.Text,
                            collegeTextBox.Text,
                            selectedFilePath
                        ))
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(3, "USER SUCCESSFULLY ADDED", "Teacher: " + lastNameTextBox.Text + " Successfully added!");
                            alert.ShowDialog();
                            ClearAllTextBoxes(this);
                        }
                        else
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(1, "ADD USER UNSUCCESSFULL", "An error has occured causing an unsuccessful transaction");
                            alert.ShowDialog();
                        }
                    }
                }
                else
                {
                    TimerOpersys.Stop();
                    alert = new FORM_ALERT(1, errorMessage[0], errorMessage[1]);
                    alert.ShowDialog();
                }
            }
            else if (conditionForAdd == (int)UserAdd.Employee)
            {
                //Check for errors
                string[] errorMessage = UserOperation.IsUserInputValid(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    middleInitialTextBox.Text.ToUpper().Trim(','),
                    emailTextBox.Text,
                    address,
                    contactNumberTextBox.Text,
                    imageCon
                    );

                //Execute operation if error message length is 0
                if (errorMessage.Length == 0)
                {
                    string password = UserOperation.GeneratePassword(); //generate random pass 

                    if (string.IsNullOrEmpty(selectedFilePath))
                    {
                        if (UserOperation.AddAdminOrEmployee(
                                emailTextBox.Text,
                                lastNameTextBox.Text,
                                firstNameTextBox.Text,                 
                                middleInitialTextBox.Text.ToUpper().Trim('.'),             
                                address,
                                contactNumberTextBox.Text,
                                (int)UserOperation.UserLevel.Employee,
                                password
                            ))
                        {
                            TimerOpersys.Stop();
                            try
                            {
                                //Load environment variables
                                DotNetEnv.Env.Load(); 
                                var senderEmail = Environment.GetEnvironmentVariable("SENDER_EMAIL");
                                var senderPass = Environment.GetEnvironmentVariable("SENDER_PASSWORD");

                                //Create email sender instance
                                IEmailSender emailSender = new SmtpEmailSender(senderEmail, senderPass);

                                //call emailSender SendEmail method to send the email with the corresponding credentials
                                emailSender.SendEmail(
                                        emailTextBox.Text,
                                        "Librarian Account Creation Successfull",
                                        emailSender.EmployeeCreationMessage(firstNameTextBox.Text + " " + middleInitialTextBox.Text + ". "+ lastNameTextBox.Text, password)
                                    );

                                //alert the user for succesful transaction
                                alert = new FORM_ALERT(3, "USER SUCCESSFULLY ADDED", "Librarian Credentials was sent to his/her email account");
                                alert.ShowDialog();
                            }
                            catch(Exception ex)
                            {
                                //Email sending failed so credentials will be shown in the alert box
                                alert = new FORM_ALERT(3, "USER SUCCESSFULLY ADDED\nREAD CAREFULLY", "SENDING OF CREDENTIALS THROUGH EMAIL FAILED\n\nEmployee: " + lastNameTextBox.Text + " Successfully added!\n" +
                                "Employee password is : " + password);
                                alert.ShowDialog();
                            }
                            ClearAllTextBoxes(this);
                        }
                        else
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(1, "ADD USER UNSUCCESSFULL", "An error has occured causing an unsuccessful transaction");
                            alert.ShowDialog();
                        }
                    }
                    else
                    {
                        if (UserOperation.AddAdminOrEmployee(
                                emailTextBox.Text,
                                lastNameTextBox.Text,
                                firstNameTextBox.Text,
                                middleInitialTextBox.Text.ToUpper().Trim(','),
                                address,
                                contactNumberTextBox.Text,
                                (int)UserOperation.UserLevel.Employee,
                                password,
                                selectedFilePath
                            ))
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(3, "USER SUCCESSFULLY ADDED\nREAD CAREFULLY", "Employee: " + lastNameTextBox.Text + " Successfully added!\n" +
                                "Employee password is : " + password);
                            alert.ShowDialog();
                            ClearAllTextBoxes(this);
                        }
                        else
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(1, "ADD USER UNSUCCESSFULL", "An error has occured causing an unsuccessful transaction");
                            alert.ShowDialog();
                        }
                    }
                }
                else
                {
                    TimerOpersys.Stop();
                    alert = new FORM_ALERT(1, errorMessage[0], errorMessage[1]);
                    alert.ShowDialog();
                }
            }
            TimerOpersys.Stop();

            if (TimerOpersys.IsEnabled) TimerOpersys.DisplayElapsedTime();
        }

        private void uploadExcelFIleButton_Click(object sender, EventArgs e)
        {
            FORM_UPLOAD upload = new FORM_UPLOAD(conditionForAddExcell);
            upload.ShowDialog();
        }
        #endregion

        private void removeImageButton_Click(object sender, EventArgs e)
        {
            SetPictureBoxImage("No_image");
        }

        private void removeImageButton_MouseEnter(object sender, EventArgs e)
        {
            removeImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
        }

        private void removeImageButton_MouseLeave(object sender, EventArgs e)
        {
            removeImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
        }
    }
}
