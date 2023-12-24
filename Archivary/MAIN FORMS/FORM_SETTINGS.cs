using Archivary._900X500;
using Archivary.BACKEND.BOOK_OPERATIONS;
using Archivary.BACKEND.COMMON_OPERATIONS;
using Archivary.BACKEND.OBJECTS;
using Archivary.BACKEND.USER_OPERATIONS;
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

namespace Archivary.PARENT_FORMS
{
    public partial class FORM_SETTINGS : Form
    {
        private int panelWidth;
        private object user;
        private string selectedFilePath;
        private bool allowSave = false;
        private Setting setting;
        public FORM_SETTINGS(object user)
        {
            InitializeComponent();
            this.user = user;
            InitializeUserInfo(user);
            InitializeSettingInfo();
        }

        private void FORM_SETTINGS_Load(object sender, EventArgs e)
        {

        }
       
        private void FORM_SETTINGS_Resize(object sender, EventArgs e)
        {

        }

        private void LoadPanels()
        {
            panelWidth = (PANEL_CONTAINER.ClientSize.Width / 1) - 10; //( -20 <-- this is padding size)

        }

        private void userId_Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            using (FORM_PASSWORD pass = new FORM_PASSWORD())
            {
                pass.ShowInTaskbar = false;
                DialogResult result = pass.ShowDialog();
            }
        }
        private void EnableAllTextBoxes(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is RoundedTextBox)
                {
                    RoundedTextBox textBox = (RoundedTextBox)control;
                    textBox.Enabled = true;
                }

                if (control.HasChildren)
                {
                    EnableAllTextBoxes(control.Controls); 
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EnableAllTextBoxes(this.Controls);
            if(user is Employee)
            {
                borrowingCapacityLabel.Enabled = false;
                reserveLimitTextBox.Enabled = false;
                borrowingDurationTextBox.Enabled = false;
            }
            changePassButton.Enabled = true;
            uploadImageButton.Enabled = true;
            allowSave = true;
        }
        private void InitializeUserInfo(object user)
        {
            if(user is Admin admin)
            {
                userId.Text = "ADMIN ID";
                userIDLabel.Text = admin.AdminId;
                lastNameTextBox.Text = admin.AdminLastName;
                firstNameTextBox.Text = admin.AdminFirstName;
                middleInitialTextBox.Text = admin.AdminMiddleName;
                emailAddressTextBox.Text = admin.AdminEmail;
                contactNumberTextBox.Text = admin.AdminContacNum;
                string[] address = UserOperation.SplitAddress(admin.AdminAddress);
                houseNumberTextBox.Text = address[0];
                streetTextBox.Text = address[1];
                barangayTextBox.Text = address[2];
                cityTextBox.Text = address[3];
                selectedFilePath = admin.AdminImagePath;
                SetPictureBoxImage(admin.AdminImagePath);
            }else if(user is Employee employee)
            {
                userId.Text = "EMPLOYEE ID";
                userIDLabel.Text = employee.EmployeeId;
                lastNameTextBox.Text = employee.EmployeeLastName;
                firstNameTextBox.Text = employee.EmployeeFirstName;
                middleInitialTextBox.Text = employee.EmployeeMiddleName;
                emailAddressTextBox.Text = employee.EmployeeEmail;
                contactNumberTextBox.Text = employee.EmployeeContactNum;
                string[] address = UserOperation.SplitAddress(employee.EmployeeAddress);
                houseNumberTextBox.Text = address[0];
                streetTextBox.Text = address[1];
                barangayTextBox.Text = address[2];
                cityTextBox.Text = address[3];
                selectedFilePath = employee.EmployeeImagePath;
                SetPictureBoxImage(employee.EmployeeImagePath);
            }
        }
        private void InitializeSettingInfo()
        {
            //Extract info for settings
            setting = CommonOperation.GetSettingsFromDatabase();
            borrowingCapacityLabel.Text = setting.borrowingCapacity.ToString();
            reserveLimitTextBox.Text = setting.reserveLimit.ToString();
            borrowingDurationTextBox.Text = setting.borrowingDuration.ToString();
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
            if (!allowSave)
            {
                MessageBox.Show("Press Edit Button First");
                return;
            }
            //Concat the each textbox for adress
            string concatAddress = houseNumberTextBox.Text + ", " + streetTextBox.Text + ", "
                + barangayTextBox.Text + ", " + cityTextBox.Text;

           if(user is Employee userEmployee)
           {
                //Check if any info has changed
                if (firstNameTextBox.Text != userEmployee.EmployeeFirstName || lastNameTextBox.Text != userEmployee.EmployeeLastName ||
                    middleInitialTextBox.Text != userEmployee.EmployeeMiddleName || emailAddressTextBox.Text != userEmployee.EmployeeEmail ||
                    concatAddress != userEmployee.EmployeeAddress || contactNumberTextBox.Text != userEmployee.EmployeeContactNum ||
                    selectedFilePath != userEmployee.EmployeeImagePath
                    )
                {
                    //Condition to bypass the userinput valid if the user still doesnt want an image
                    string conditionImage = (selectedFilePath == "NO_IMAGE") ? "No_image" : selectedFilePath;
                    //Condition to bypass the userinput valid if the user still doesnt to change email
                    string conditionEmail = (emailAddressTextBox.Text == userEmployee.EmployeeEmail) ? UserOperation.GeneratePassword() + "@gmail.com" : emailAddressTextBox.Text;
                    //Check user input, returns array of string which contains the message
                    string[] errorMessage = UserOperation.IsUserInputValid(
                        firstNameTextBox.Text,
                        lastNameTextBox.Text,
                        middleInitialTextBox.Text,
                        conditionEmail,
                        concatAddress,
                        contactNumberTextBox.Text,
                        conditionImage
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
                        if (UserOperation.UpdateUserInformation(
                            userEmployee.EmployeeUserId,
                            firstNameTextBox.Text,
                            lastNameTextBox.Text,
                            middleInitialTextBox.Text,
                            concatAddress,
                            contactNumberTextBox.Text,
                            selectedFilePath
                            ))
                        {
                            UpdateUserObject(concatAddress); // Update the object referenced
                            MessageBox.Show("Employee Info Update Successful");
                            InitializeUserInfo(user);
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
           else if (user is Admin userAdmin)
           {
                //Check if any info has changed
                if (firstNameTextBox.Text != userAdmin.AdminFirstName || lastNameTextBox.Text != userAdmin.AdminLastName ||
                    middleInitialTextBox.Text != userAdmin.AdminMiddleName || emailAddressTextBox.Text != userAdmin.AdminEmail ||
                    concatAddress != userAdmin.AdminAddress || contactNumberTextBox.Text != userAdmin.AdminContacNum ||
                    selectedFilePath != userAdmin.AdminImagePath
                    )
                {
                    //Condition to bypass the userinput valid if the user still doesnt want an image
                    string conditionImage = (selectedFilePath == "NO_IMAGE") ? "No_image" : selectedFilePath;
                    //Condition to bypass the userinput valid if the user still doesnt to change email
                    string conditionEmail = (emailAddressTextBox.Text == userAdmin.AdminEmail) ? UserOperation.GeneratePassword() + "@gmail.com" : emailAddressTextBox.Text;
                    //Check user input, returns array of string which contains the message
                    string[] errorMessage = UserOperation.IsUserInputValid(
                        firstNameTextBox.Text,
                        lastNameTextBox.Text,
                        middleInitialTextBox.Text,
                        conditionEmail,
                        concatAddress,
                        contactNumberTextBox.Text,
                        conditionImage
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
                        if (UserOperation.UpdateUserInformation(
                            userAdmin.AdminUserId,
                            firstNameTextBox.Text,
                            lastNameTextBox.Text,
                            middleInitialTextBox.Text,
                            concatAddress,
                            contactNumberTextBox.Text,
                            selectedFilePath
                            ))
                        {
                            UpdateUserObject(concatAddress); // Update the object referenced
                            MessageBox.Show("Admin Info Update Successful");
                            InitializeUserInfo(user);
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
                if(borrowingCapacityLabel.Text != setting.borrowingCapacity.ToString() || reserveLimitTextBox.Text != setting.reserveLimit.ToString()
                    || borrowingDurationTextBox.Text != setting.borrowingDuration.ToString())
                {
                    if (!UserOperation.IsValidInteger(borrowingCapacityLabel.Text))
                    {
                        MessageBox.Show("Borrowing Capacity Input is Not a Valid Integer");
                        return;
                    }
                    if (!UserOperation.IsValidInteger(reserveLimitTextBox.Text))
                    {
                        MessageBox.Show("Reserve Limit Input is Not a Valid Integer");
                        return;
                    }
                    if (!UserOperation.IsValidInteger(borrowingDurationTextBox.Text))
                    {
                        MessageBox.Show("Borrowing Duration Input is Not a Valid Integer");
                        return;
                    }

                    if (CommonOperation.UpdateSettings(
                        int.Parse(borrowingCapacityLabel.Text),
                        int.Parse(reserveLimitTextBox.Text),
                        int.Parse(borrowingDurationTextBox.Text)
                        ))
                    {
                        MessageBox.Show("Settings Update successful");
                        InitializeSettingInfo();
                    }
                    else MessageBox.Show("Settings Update Unsuccessful");
                }
           }
        }
        private void UpdateUserObject(string concatAddress)
        {
            if(user is Employee userEmployee)
            {
                userEmployee.EmployeeFirstName = firstNameTextBox.Text;
                userEmployee.EmployeeLastName = lastNameTextBox.Text;
                userEmployee.EmployeeMiddleName = middleInitialTextBox.Text;
                userEmployee.EmployeeAddress = concatAddress;
                userEmployee.EmployeeContactNum = contactNumberTextBox.Text;
                userEmployee.EmployeeImagePath = selectedFilePath;
            }else if (user is Admin userAdmin)
            {
                userAdmin.AdminFirstName = firstNameTextBox.Text;
                userAdmin.AdminLastName = lastNameTextBox.Text;
                userAdmin.AdminMiddleName = middleInitialTextBox.Text;
                userAdmin.AdminAddress = concatAddress;
                userAdmin.AdminContacNum = contactNumberTextBox.Text;
                userAdmin.AdminImagePath = selectedFilePath;
            }
        }
    }
}
