using roundedCorners;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

    }
}
