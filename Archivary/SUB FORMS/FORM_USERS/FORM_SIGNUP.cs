using Archivary.BACKEND.USER_OPERATIONS;
using custom;
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
        private int conditionForAdd = 0;
        private string selectedFilePath = "";

        private enum UserAdd
        {
            Student = 0,
            Teacher = 1,
            Employee = 2,
        }

        public FORM_SIGNUP()
        {
            InitializeComponent();
            ActivateButton(studentButton);
            SetPictureBoxImage("No_image");
        }
        private void DrawCustomBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth)
        {
            ControlPaint.DrawBorder(graphics, rectangle, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid);
        }
        private void FORM_SIGNUP_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(37, 211, 102), 3);//3 represents the border width
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
            //visibility of textboxes and labels 
            collegeLabel.Visible = true;
            collegeTextBox.Visible = true;
            PANEL_CONTENTS.SetColumnSpan(collegeTextBox, 3);
            yearLabel.Visible = true;
            yearTextBox.Visible = true;
            sectionLabel.Visible = true;
            sectionTextBox.Visible = true;
            collegeTextBox.Size = new System.Drawing.Size(398, 38);
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ClearAllTextBoxes(this);
            SetPictureBoxImage("No_image"); //to clear ImageBox when the button is clicked
            conditionForAdd = (int)UserAdd.Teacher;

            //visibility of textboxes and labels 
            collegeLabel.Visible = true;
            collegeTextBox.Visible = true;
            PANEL_CONTENTS.SetColumnSpan(collegeTextBox, 5);
            yearLabel.Visible = false;
            yearTextBox.Visible = false;
            sectionLabel.Visible = false;
            sectionTextBox.Visible = false;
            collegeTextBox.Size = new System.Drawing.Size(651, 38);

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

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Concat address
            string address = (houseNumberTextBox.Text + ", " + streetTextBox.Text + ", " + barangayTextBox.Text +
                ", " + cityTextBox.Text);

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
                    middleInitialTextBox.Text,
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
                        middleInitialTextBox.Text,
                        emailTextBox.Text,
                        address,
                        contactNumberTextBox.Text,
                        collegeTextBox.Text,
                        int.Parse(yearTextBox.Text),
                        sectionTextBox.Text
                        ))
                        {
                            MessageBox.Show("Student: " + lastNameTextBox.Text + " Successfully added!");
                        }
                        else
                        {
                            MessageBox.Show("An error has occured\nunsuccessful transaction");
                        }
                    }
                    else
                    {
                        if (UserOperation.AddStudent(
                        firstNameTextBox.Text,
                        lastNameTextBox.Text,
                        middleInitialTextBox.Text,
                        emailTextBox.Text,
                        address,
                        contactNumberTextBox.Text,
                        collegeTextBox.Text,
                        int.Parse(yearTextBox.Text),
                        sectionTextBox.Text,
                        selectedFilePath
                        ))
                        {
                            MessageBox.Show("Student: " + lastNameTextBox.Text + " Successfully added!");
                        }
                        else
                        {
                            MessageBox.Show("An error has occured\nunsuccessful transaction");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage[0] + "\n" + errorMessage[1]);
                }
            }
            else if (conditionForAdd == (int)UserAdd.Teacher)
            {
                //Check for errors
                string[] errorMessage = UserOperation.IsUserInputValid(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    middleInitialTextBox.Text,
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
                            middleInitialTextBox.Text,
                            emailTextBox.Text,
                            address,
                            contactNumberTextBox.Text,
                            collegeTextBox.Text
                            ))
                        {
                            MessageBox.Show("Teacher: " + lastNameTextBox.Text  + " Successfully added!");
                        }
                        else
                        {
                            MessageBox.Show("An error has occured\nunsuccessful transaction");
                        }
                    }
                    else
                    {
                        if (UserOperation.AddTeacher(
                            firstNameTextBox.Text,
                            lastNameTextBox.Text,
                            middleInitialTextBox.Text,
                            emailTextBox.Text,
                            address,
                            contactNumberTextBox.Text,
                            collegeTextBox.Text,
                            selectedFilePath
                        ))
                        {
                            MessageBox.Show("Teacher: " + lastNameTextBox.Text + " Successfully added!");
                        }
                        else
                        {
                            MessageBox.Show("An error has occured\nunsuccessful transaction");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage[0] + "\n" + errorMessage[1]);
                }
            }
            else if (conditionForAdd == (int)UserAdd.Employee)
            {
                //Check for errors
                string[] errorMessage = UserOperation.IsUserInputValid(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    middleInitialTextBox.Text,
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
                                middleInitialTextBox.Text,             
                                address,
                                contactNumberTextBox.Text,
                                (int)UserOperation.UserLevel.Employee,
                                password
                            ))
                        {
                            MessageBox.Show("Employee: " + lastNameTextBox.Text + " Successfully added!\n" +
                                "Employee Password is: " + password);
                        }
                        else
                        {
                            MessageBox.Show("An error has occured\nunsuccessful transaction");
                        }
                    }
                    else
                    {
                        if (UserOperation.AddAdminOrEmployee(
                                emailTextBox.Text,
                                lastNameTextBox.Text,
                                firstNameTextBox.Text,
                                middleInitialTextBox.Text,
                                address,
                                contactNumberTextBox.Text,
                                (int)UserOperation.UserLevel.Employee,
                                password,
                                selectedFilePath
                            ))
                        {
                            MessageBox.Show("Employee: " + lastNameTextBox.Text + " Successfully added!\n" +
                                "Employee Password is: " + password);
                        }
                        else
                        {
                            MessageBox.Show("An error has occured\nunsuccessful transaction");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage[0] + "\n" + errorMessage[1]);
                }
            }
            ClearAllTextBoxes(this);
        }
    }
}
