using Archivary._900X500;
using Archivary.BACKEND.OBJECTS;
using Archivary.BACKEND.TIMER;
using Archivary.PARENT_FORMS;
using Archivary.SUB_FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary._1500X1000.FORM_CIRCULATION
{
    public partial class FORM_POS : Form
    {
        private List<Book> selectedBooks;
        private List<DateTime> borrowedDates;
        private int borrowerId;
        private decimal totalCost, payment, change;
        private object user;
        public FORM_POS(List<Book> selectedBooks, List<DateTime> borrowedDates, int borrowerId, object user)
        {
            InitializeComponent();
            this.selectedBooks = selectedBooks;
            this.borrowedDates = borrowedDates;
            this.borrowerId = borrowerId;
            this.user = user;
        }
        private void FORM_POS_Load(object sender, EventArgs e)
        {
            this.Size = new Size(970, 670);
            PutSelectedBooks(selectedBooks, borrowedDates);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.FromArgb(29, 185, 84)), e.ClipRectangle);
        }

        private void PutSelectedBooks(List<Book> selectedBooks, List<DateTime> borrowedDates)
        {
            Setting settings = Archivary.BACKEND.COMMON_OPERATIONS.CommonOperation.GetSettingsFromDatabase();
            for (int i = 0; i < selectedBooks.Count; i++)
            {
                AddBooksInDataGridView(selectedBooks[i], borrowedDates[i], settings);
            }
            UpdateChange();
        }

        private void AddBooksInDataGridView(Book book, DateTime borrowedDate, Setting settings)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell { Value = book.BookTitle });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = book.BookISBN });
            string formattedDate = borrowedDate.ToString("MMMM d, yyyy");
            row.Cells.Add(new DataGridViewTextBoxCell { Value = formattedDate });
            DateTime bookToReturn = borrowedDate.AddDays(settings.borrowingDuration);
            row.Cells.Add(new DataGridViewTextBoxCell { Value = bookToReturn.ToString("MMMM d, yyyy") });
            int fee = DeterminePenalty(bookToReturn, settings);
            string formattedFee = fee.ToString();
            row.Cells.Add(new DataGridViewTextBoxCell { Value = formattedFee });
            bookDataGridView.Rows.Add(row);
        }

        private int DeterminePenalty(DateTime dateToReturn, Setting settings)
        {
            TimeSpan difference = DateTime.Now - dateToReturn;
            int daysOverdue = (int)difference.TotalDays;

            if (daysOverdue <= 0)
            {
                return 0;
            }

            int initialPenalty = settings.overdueFee;
            int additionalPenaltyPerDay = settings.additionalOverdueFee;

            int totalPenalty = initialPenalty + (daysOverdue - 1) * additionalPenaltyPerDay;

            return totalPenalty;
        }

        private decimal SetTotalCost()
        {
            decimal totalCost = 0;

            foreach (DataGridViewRow row in bookDataGridView.Rows)
            {
                object cellValue = row.Cells[4].Value;
                if (cellValue != null)
                {
                    if (decimal.TryParse(cellValue.ToString(), out decimal cellDecimalValue))
                    {
                        Console.WriteLine(cellValue);
                        Console.WriteLine(cellDecimalValue);
                        totalCost += cellDecimalValue;
                    }
                }
            }
            return totalCost;
        }

        private void UpdateChange()
        {
            totalCost = SetTotalCost();
            totalTextBox.Text = totalCost.ToString();
            payment = 0;
            if (decimal.TryParse(paymentTextBox.Text.ToString(), out decimal paymentValue))
            {
                payment = paymentValue;
            }
            change = payment - totalCost;
            changeTextBox.Text = change.ToString();
        }

        private void FORM_POS_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(37, 211, 102), 3);
        }
        private void DrawCustomBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth)
        {
            ControlPaint.DrawBorder(graphics, rectangle, color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid);
        }

        private void totalPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomCellBorder(e.Graphics, totalPanel.ClientRectangle, Color.FromArgb(37, 211, 102), 10, totalPanel);
        }
        private void changePanel_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomCellBorder(e.Graphics, totalPanel.ClientRectangle, Color.FromArgb(37, 211, 102), 10, totalPanel);

        }

        private void paymentPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomCellBorder(e.Graphics, totalPanel.ClientRectangle, Color.FromArgb(37, 211, 102), 10, totalPanel);
        }
        private void DrawCustomCellBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth, TableLayoutPanel tableLayoutPanel)
        {

            using (Pen pen = new Pen(color, borderWidth))
            {
                graphics.DrawRectangle(pen, rectangle);
                rectangle.Inflate(-borderWidth / 2, -borderWidth / 2);

                for (int i = 1; i < tableLayoutPanel.RowCount; i++)
                {
                    int y = tableLayoutPanel.GetRowHeights().Take(i).Sum();
                    graphics.DrawLine(pen, rectangle.Left, y, rectangle.Right, y);
                }
                /*for(int i = 1; i < tableLayoutPanel.ColumnCount; i++)
                {
                    int x = tableLayoutPanel.GetColumnWidths().Take(i).Sum();
                    graphics.DrawLine(pen, x,rectangle.Top, x, rectangle.Bottom );
                }*/
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            TimerOpersys.Start();
            UpdateChange();
            TimerOpersys.Stop();
            if(TimerOpersys.IsEnabled)TimerOpersys.DisplayElapsedTime();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            TimerOpersys.Start();
            if(payment < totalCost)
            {
                FORM_ALERT error = new FORM_ALERT(3, "NOT ENOUGH PAYMENT", "You must pay the total cost.");
                error.TopMost = true;
                error.Show();
                return;
            }

            foreach (Book book in selectedBooks)
            {
                Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.SetBorrowedBookToReturned(book, borrowerId, user is Admin admin ? admin.AdminUserId : ((Employee)user).EmployeeUserId);
            }
            FORM_ALERT alert = new FORM_ALERT(3, "BOOKS RETURNED", "Successfully returned books!");
            alert.TopMost = true;
            alert.Show();
            this.Dispose();
            TimerOpersys.Stop
            if (TimerOpersys.IsEnabled) TimerOpersys.DisplayElapsedTime();
        }
    }
}