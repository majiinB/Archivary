using Archivary.BACKEND.BOOK_OPERATIONS;
using Archivary.BACKEND.COMMON_OPERATIONS;
using Archivary.BACKEND.TIMER;
using Archivary.BACKEND.USER_OPERATIONS;
using roundedCorners;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary._900X500
{
    public partial class FORM_UPLOAD : Form
    {
        private bool isFormatToggled = false;
        private bool isInstructionsToggled = false;
        private int height = 0;
        private int condition = -1;
        private bool isDataLoading = false;
        private string selectedFilePath = "fileName.xlsx";
        //private string workSheetName = "WorkSheet1";
        //private int startingRow = 2;
        private FORM_ALERT alert;
        public enum EXCEL_FORMAT
        {
            Book = 1,
            Teacher = 2,
            Student = 3
        }
        public FORM_UPLOAD(int condition)
        {
            InitializeComponent();
            // this.DoubleBuffered = true;
            this.condition = condition;
            ShowInTaskbar = false;

            if (condition == (int)EXCEL_FORMAT.Book)
            {
                // 564;
                height = 634;
                excelBookFormat.Visible = true;
            }
            else if (condition == (int)EXCEL_FORMAT.Teacher)
            {
                //407
                height = 477;
                excelTeacherFormat.Visible = true;
            }
            else if (condition == (int)EXCEL_FORMAT.Student)
            {
                //422
                height = 492;
                excelStudentFormat.Visible = true;
            }
        }

        private void FORM_UPLOAD_Load(object sender, EventArgs e)
        {
            LAYOUT_UPLOAD.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15); 
            LAYOUT_FORMAT.Size = new System.Drawing.Size(760, 50);
            LAYOUT_INSTRUCTIONS.Size = new System.Drawing.Size(760, 50);
            formatButton.BackgroundImage = global::Archivary.Properties.Resources.ICON_TOGGLE_OPEN;
            instructionsButton.BackgroundImage = global::Archivary.Properties.Resources.ICON_TOGGLE_OPEN;
            isFormatToggled = !isFormatToggled;
            isInstructionsToggled = !isInstructionsToggled;
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            isInstructionsToggled = !isInstructionsToggled;
            collapse(LAYOUT_INSTRUCTIONS, instructionsButton, isInstructionsToggled, 350);
            resizeUploadPanel(isFormatToggled, isInstructionsToggled); // check if layout should be resized 
        }
        private void formatButton_Click(object sender, EventArgs e)
        {
            isFormatToggled = !isFormatToggled;
            collapse(LAYOUT_FORMAT, formatButton, isFormatToggled, height);
            resizeUploadPanel(isFormatToggled, isInstructionsToggled); // check if layout should be resized 
        }
        private void collapse(Panel panel, roundedButton button, bool isToggled, int height)
        {
            if (isToggled) //close
            {
                panel.Size = new System.Drawing.Size(733, 50);
                button.BackgroundImage = global::Archivary.Properties.Resources.ICON_TOGGLE_OPEN;
            }
            else//open
            {
                LAYOUT_UPLOAD.Padding = new System.Windows.Forms.Padding(15, 15, 45, 15);//bigyan ng space ung scrololbar
                panel.Size = new System.Drawing.Size(733, height);
                button.BackgroundImage = global::Archivary.Properties.Resources.ICON_TOGGLE_CLOSE;
            }
        }

        private void resizeUploadPanel(bool toggle1, bool toggle2)
        {
            if (isFormatToggled && isInstructionsToggled)
            {
                LAYOUT_UPLOAD.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            }
        }
        private void FORM_UPLOAD_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        //d ko muna gagamitin, ksi nagloloko ung form dahil sa custom border
        private void DrawCustomBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth)
        {
             ControlPaint.DrawBorder(graphics, rectangle, color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void uploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs())
                {
                    await PerformFileUpload();
                }
            }
            catch (Exception ex)
            {
                // Handle and log the exception
                alert = new FORM_ALERT(1, "ERROR", $"An error occurred: {ex.Message}");
                alert.ShowDialog();
            }
            finally
            {
                isDataLoading = false;
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select a File";
            openFileDialog.Filter = "Excel Files|*.xlsx";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                fileTextbox.Text = selectedFilePath;
            }
        }

        private bool ValidateInputs()
        {
            //Input validation
            if (string.IsNullOrEmpty(fileTextbox.Text) || selectedFilePath == "fileName.xlsx")
            {
                alert = new FORM_ALERT(1, "INVALID INPUT", "File textbox is empty");
                alert.ShowDialog();
                return false;
            }
            if (!UserOperation.DoesFileExistAndIsXlsx(selectedFilePath))
            {
                alert = new FORM_ALERT(1, "INVALID INPUT", "File does not exist");
                alert.ShowDialog();
                return false;
            }
            if (string.IsNullOrEmpty(worksheetTextbox.Text))
            {
                alert = new FORM_ALERT(1, "INVALID INPUT", "Worksheet textbox is empty");
                alert.ShowDialog();
                return false;
            }
            if (string.IsNullOrEmpty(startingRowTextbox.Text))
            {
                alert = new FORM_ALERT(1, "INVALID INPUT", "Starting row textbox is empty");
                alert.ShowDialog();
                return false;
            }
            if (!UserOperation.IsValidInteger(startingRowTextbox.Text))
            {
                alert = new FORM_ALERT(1, "INVALID INPUT", "Starting row is not a valid integer");
                alert.ShowDialog();
                return false;
            }
            return true;
        }
        private async Task PerformFileUpload()
        {
            //Upload file
            if (condition == (int)EXCEL_FORMAT.Student)
            {
                if (!isDataLoading)
                {
                    isDataLoading = true;
                    await Task.Run(() =>
                    {
                        TimerOpersys.Start();
                        List<string> confirmation = UserOperation.AddStudentByExcel(selectedFilePath, worksheetTextbox.Text, int.Parse(startingRowTextbox.Text));
                        if (confirmation.Count == 0)
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(3, "UPLOAD SUCCESSFUL", "Upload success and did not encounter any errors");
                            alert.ShowDialog();
                        }
                        else
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(1, "UPLOAD ENCOUNTERED ERRORS", "Student info upload completed but encountered some errors\n\n" + CommonOperation.ConcatenateList(confirmation));
                            alert.ShowDialog();
                        }
                        if (TimerOpersys.IsEnabled) TimerOpersys.DisplayElapsedTime();
                        isDataLoading = false;
                    });
                }
            }else if(condition == (int)EXCEL_FORMAT.Teacher)
            {
                if (!isDataLoading)
                {
                    isDataLoading = true;
                    await Task.Run(() =>
                    {
                        TimerOpersys.Start();
                        List<string> confirmation = UserOperation.AddTeacherByExcel(selectedFilePath, worksheetTextbox.Text, int.Parse(startingRowTextbox.Text));
                        if (confirmation.Count == 0)
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(3, "UPLOAD SUCCESSFUL", "Upload success and did not encounter any errors");
                            alert.ShowDialog();
                        }
                        else
                        {
                            TimerOpersys.Stop();
                            alert = new FORM_ALERT(1, "UPLOAD ENCOUNTERED ERRORS", "Teacher info upload completed but encountered some errors\n\n" + CommonOperation.ConcatenateList(confirmation));
                            alert.ShowDialog();
                        }
                        if (TimerOpersys.IsEnabled) TimerOpersys.DisplayElapsedTime();
                        isDataLoading = false;
                    });
                }
            }else if(condition == (int)EXCEL_FORMAT.Book)
            {
                isDataLoading = true;
                await Task.Run(() =>
                {
                    TimerOpersys.Start();
                    List<string> confirmation = BookOperation.AddBookByExcel(selectedFilePath, worksheetTextbox.Text, int.Parse(startingRowTextbox.Text));
                    if (confirmation.Count == 0)
                    {
                        TimerOpersys.Stop();
                        alert = new FORM_ALERT(3, "UPLOAD SUCCESSFUL", "Upload success and did not encounter any errors");
                        alert.ShowDialog();
                    }
                    else
                    {
                        TimerOpersys.Stop();
                        alert = new FORM_ALERT(1, "UPLOAD ENCOUNTERED ERRORS", "Book info upload completed but encountered some errors\n\n" + CommonOperation.ConcatenateList(confirmation));
                        alert.ShowDialog();
                    }
                    if (TimerOpersys.IsEnabled) TimerOpersys.DisplayElapsedTime();
                    isDataLoading = false;
                });
            }
        }
    }
}
