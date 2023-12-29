using Archivary._900X500;
using Archivary.BACKEND.BOOK_OPERATIONS;
using Archivary.BACKEND.COMMON_OPERATIONS;
using Archivary.BACKEND.OBJECTS;
using Archivary.BACKEND.USER_OPERATIONS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Archivary.PARENT_FORMS
{
    public partial class FORM_SETTINGS : Form
    {
        private roundedButton currentBtn; //<--- for activating button
        private int panelWidth;
        private object user;
        private string selectedFilePath;
        private bool allowSave = false;
        private Setting setting;
        FORM_PASSWORD pass;
        FORM_ALERT alert;

        //Define an event for the Save button click
        public event EventHandler SaveButtonClicked;

        public FORM_SETTINGS(object user)
        {
            InitializeComponent();
            this.user = user;
            InitializeUserInfo(user);
            InitializeSettingInfo();

            //front end stuff for the listview
            genreListView.OwnerDraw = true;
            genreListView.DrawItem += genreListView_DrawItem;
            genreListView.DrawSubItem += genreListView_DrawSubItem;
            genreListView.DrawColumnHeader += genreListView_DrawColumnHeader;
            ActivateButton(fictionButton);

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
            using (pass = new FORM_PASSWORD(user))
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
                alert = new FORM_ALERT(1, "IMAGE ERROR", $"Error loading image: {ex.Message}");
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
            if (!allowSave)
            {
                alert = new FORM_ALERT(1, "ACTION ERROR", "Press Edit Button First");
                alert.ShowDialog();
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
                        alert = new FORM_ALERT(1, "INVALID ADRESS", "One of the textbox for address is empty");
                        alert.ShowDialog();
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
                            alert = new FORM_ALERT(3, "INFORMATIONS UPDATE SUCCESSFUL", "Employee Info Update Successful");
                            alert.ShowDialog();
                            InitializeUserInfo(user);
                            SaveButtonClicked?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            //Error message for update
                            alert = new FORM_ALERT(1, "INFORMATIONS UPDATE FAILURE", "An error has occured during the update");
                            alert.ShowDialog();
                        }
                    }
                    else
                    {
                        alert = new FORM_ALERT(1, errorMessage[0], errorMessage[1]);
                        alert.ShowDialog();
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
                        alert = new FORM_ALERT(1, "INVALID ADRESS", "One of the textbox for address is empty");
                        alert.ShowDialog();
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
                            alert = new FORM_ALERT(3, "INFORMATIONS UPDATE SUCCESSFUL", "Admin Info Update Successful");
                            alert.ShowDialog();
                            InitializeUserInfo(user);
                            SaveButtonClicked?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            //Error message for update
                            alert = new FORM_ALERT(1, "INFORMATIONS UPDATE FAILURE", "An error has occured during the update");
                            alert.ShowDialog();
                        }
                    }
                    else
                    {
                        //Error message for input validation
                        alert = new FORM_ALERT(1, errorMessage[0], errorMessage[1]);
                        alert.ShowDialog();
                    }
                }
                if(borrowingCapacityLabel.Text != setting.borrowingCapacity.ToString() || reserveLimitTextBox.Text != setting.reserveLimit.ToString()
                    || borrowingDurationTextBox.Text != setting.borrowingDuration.ToString())
                {
                    if (!UserOperation.IsValidInteger(borrowingCapacityLabel.Text))
                    {
                        alert = new FORM_ALERT(1, "BORROWING CAPACITY INPUT ERROR", "Borrowing Capacity Input is Not a Valid Integer");
                        alert.ShowDialog();
                        return;
                    }
                    if (!UserOperation.IsValidInteger(reserveLimitTextBox.Text))
                    {
                        alert = new FORM_ALERT(1, "RESERVATON LIMIT INPUT ERROR", "Reserve Limit Input is Not a Valid Integer");
                        alert.ShowDialog();
                        return;
                    }
                    if (!UserOperation.IsValidInteger(borrowingDurationTextBox.Text))
                    {
                        alert = new FORM_ALERT(1, "BORROW DURATION INPUT ERROR", "Borrowing Duration Input is Not a Valid Integer");
                        alert.ShowDialog();
                        return;
                    }

                    if (CommonOperation.UpdateSettings(
                        int.Parse(borrowingCapacityLabel.Text),
                        int.Parse(reserveLimitTextBox.Text),
                        int.Parse(borrowingDurationTextBox.Text)
                        ))
                    {
                        alert = new FORM_ALERT(3, "SETTING UPDATE SUCCESSFUL", "Settings is now updated and will be applied to future transactions");
                        alert.ShowDialog();
                        InitializeSettingInfo();
                    }
                    else
                    {
                        alert = new FORM_ALERT(3, "SETTING UPDATE UNSUCCESSFUL", "An error occured during the update process");
                        alert.ShowDialog();
                    }
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
        private void genreListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true; 

        }

        private void genreListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }
        private void genreListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            int red = 208;
            int green = 190;
            int blue = 143;

            Color customColor = Color.FromArgb(red, green, blue);
            using (SolidBrush customBrush = new SolidBrush(customColor))
            {
                e.Graphics.FillRectangle(customBrush, e.Bounds);

                TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.FromArgb(244,244,244), TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

            }
        }

        private void genreListView_SizeChanged(object sender, EventArgs e)
        {
            genreListView.Columns[0].Width = genreListView.ClientSize.Width;

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

        private void fictionButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            genreListView.ForeColor = System.Drawing.Color.FromArgb(244, 244, 244);

            genreListView.Items.Clear();
                string[] genres = {
                    "Fantasy", "Mystery", "Thriller", "Romance", "Horror", "Children's Literature", "Science Fiction", "Historical Fiction",
                    "Young Adult", "Action", "Adventure", "Supernatural", "Comedy/Satire", "Psychological Fiction", "Apocalyptic/Post-Apocalyptic"
                };

            foreach (string genre in genres)
            {
                genreListView.Items.Add(genre);
            }

        }

        private void nonFicButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            genreListView.ForeColor = System.Drawing.Color.FromArgb(244, 244, 244);

            genreListView.Items.Clear();
            string[] genres = {
                    "Autobiography/Biography/Memoir", "Food and Cooking", "Health and Wellness", "Self Help", "Technology",  "Travel and Exploration"
            };

            foreach (string genre in genres)
            {
                genreListView.Items.Add(genre);
            }
        }

        private void acadButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            genreListView.ForeColor = System.Drawing.Color.FromArgb(244, 244, 244);

            genreListView.Items.Clear();
            string[] genres = {
                    "English", "Filipino", "History", "Mathematics", "Philosophy", "Science and Nature"
            };

            foreach (string genre in genres)
            {
                genreListView.Items.Add(genre);
            }

        }
      
    }
}
