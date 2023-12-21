using Archivary.Archivary_Components;
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
    public partial class FORM_REPORTS : Form
    {
        /*private monthlyOverview monthlyOverview;
        private booksReserved booksReserved;
        private booksBorrowed booksBorrowed;*/

        public FORM_REPORTS()
        {
            InitializeComponent();
        }

        private void FORM_REPORTS_Load(object sender, EventArgs e)
        {
              monthlyOverview1.Width = LAYOUT_REPORT.ClientSize.Width - 30;
            booksReserved1.Width = LAYOUT_REPORT.ClientSize.Width - 30;
            booksBorrowed1.Width = LAYOUT_REPORT.ClientSize.Width - 30;


            monthlyOverview1.Height = LAYOUT_REPORT.ClientSize.Width /2;
            booksReserved1.Height = LAYOUT_REPORT.ClientSize.Width / 2;
            booksBorrowed1.Height = LAYOUT_REPORT.ClientSize.Width / 2;

            //sample data for monthly overview
            monthlyOverview1.BooksLoaned.Points.AddXY("JAN", 1);
            monthlyOverview1.BooksLoaned.Points.AddXY("FEB", 10);
            monthlyOverview1.BooksLoaned.Points.AddXY("MAR", 10);
            monthlyOverview1.BooksLoaned.Points.AddXY("APR", 11);
            monthlyOverview1.BooksLoaned.Points.AddXY("MAY", 10);
            monthlyOverview1.BooksLoaned.Points.AddXY("JUN", 10);
            monthlyOverview1.BooksLoaned.Points.AddXY("JUL", 10);
            monthlyOverview1.BooksLoaned.Points.AddXY("AUG", 10);
            monthlyOverview1.BooksLoaned.Points.AddXY("SEP", 10);
            monthlyOverview1.BooksLoaned.Points.AddXY("OCT", 10);
            monthlyOverview1.BooksLoaned.Points.AddXY("NOV", 10);
            monthlyOverview1.BooksLoaned.Points.AddXY("DEC", 1);
            monthlyOverview1.BooksReserved.Points.AddXY("JAN", 11);
            monthlyOverview1.BooksReserved.Points.AddXY("FEB", 55);
            monthlyOverview1.BooksReserved.Points.AddXY("MAR", 77);
            monthlyOverview1.BooksReserved.Points.AddXY("APR", 10);
            monthlyOverview1.BooksReserved.Points.AddXY("MAY", 6);
            monthlyOverview1.BooksReserved.Points.AddXY("JUN", 10);
            monthlyOverview1.BooksReserved.Points.AddXY("JUL", 33);
            monthlyOverview1.BooksReserved.Points.AddXY("AUG", 11);
            monthlyOverview1.BooksReserved.Points.AddXY("SEP", 10);
            monthlyOverview1.BooksReserved.Points.AddXY("OCT", 13);
            monthlyOverview1.BooksReserved.Points.AddXY("NOV", 12);
            monthlyOverview1.BooksReserved.Points.AddXY("DEC", 10);
            monthlyOverview1.BooksReturned.Points.AddXY("JAN", 50);
            monthlyOverview1.BooksReturned.Points.AddXY("FEB", 10);
            monthlyOverview1.BooksReturned.Points.AddXY("MAR", 15);
            monthlyOverview1.BooksReturned.Points.AddXY("APR", 60);
            monthlyOverview1.BooksReturned.Points.AddXY("MAY", 11);
            monthlyOverview1.BooksReturned.Points.AddXY("JUN", 10);
            monthlyOverview1.BooksReturned.Points.AddXY("JUL", 18);
            monthlyOverview1.BooksReturned.Points.AddXY("AUG", 13);
            monthlyOverview1.BooksReturned.Points.AddXY("SEP", 10);
            monthlyOverview1.BooksReturned.Points.AddXY("OCT", 60);
            monthlyOverview1.BooksReturned.Points.AddXY("NOV", 10);
            monthlyOverview1.BooksReturned.Points.AddXY("DEC", 33);
            
            monthlyOverview1.CategoryCopies.Points.AddXY("Academic", 10);
            monthlyOverview1.CategoryCopies.Points.AddXY("Fiction", 50);
            monthlyOverview1.CategoryCopies.Points.AddXY("Non-Fiction", 30);

            string[] genres = {"English","Filipino","History","Mathematics","Philosophy","Science and Nature",
            "Autobiography/Biography/Memoir", "Food and Cooking", "Health and Wellness", "Self Help", "Technology","Travel and Exploration",
            "Fantasy","Mystery","Thriller","Romance","Horror", "Children's Literature", "Science Fiction", "Young Adult"
            , "Action","Adventure", "Supernatural", "Comedy/Satire","Psychological Fiction","Apocalyptic/Post-Apocalyptic"};
            Random random = new Random();
            monthlyOverview1.GenreCopies.Points.AddXY("English", 31);
            monthlyOverview1.GenreCopies.Points.AddXY("History", 177);
            monthlyOverview1.GenreCopies.Points.AddXY("Supernatural", 66);
            monthlyOverview1.GenreCopies.Points.AddXY("Romance", 23);
            monthlyOverview1.GenreCopies.Points.AddXY("Action", 15);
            monthlyOverview1.GenreCopies.Points.AddXY("Adventure", 47);
            monthlyOverview1.GenreCopies.Points.AddXY("Supernatural", 88);
            monthlyOverview1.GenreCopies.Points.AddXY("Comedy/Satire", 7);
            monthlyOverview1.GenreCopies.Points.AddXY("Psychological Fiction", 37);
            monthlyOverview1.GenreCopies.Points.AddXY("English", 31);
            monthlyOverview1.GenreCopies.Points.AddXY("History", 177);
            monthlyOverview1.GenreCopies.Points.AddXY("Supernatural", 66);
            monthlyOverview1.GenreCopies.Points.AddXY("Romance", 23);
            monthlyOverview1.GenreCopies.Points.AddXY("Action", 15);
            monthlyOverview1.GenreCopies.Points.AddXY("Adventure", 47);
            monthlyOverview1.GenreCopies.Points.AddXY("Supernatural", 88);
            monthlyOverview1.GenreCopies.Points.AddXY("Comedy/Satire", 7);
            monthlyOverview1.GenreCopies.Points.AddXY("Psychological Fiction", 37);



            //sample data books borowed
            int n = 100;
            for (int i = 1; i <= n; i++)
            {
                booksBorrowed1.BorrowDataGridView.Rows.Add("hh" + i, "ddadsgdffffgdsfgsdgdfgdfgv", "ss" + (i * 7), "ss", "aa", "aa", "Overdue");
                booksBorrowed1.BorrowDataGridView.Rows.Add("hh" + i, "ddadsgdffffgdsfgsdgdfgdfgv", "ss" + (i * 7), "ss", "aa", "aa", "Not Overdue");
                booksReserved1.ReserveDataGridView.Rows.Add("hh" + i, "ddadsgdffffgdsfgsdgdfgdfgv", "ss" + (i * 7), "ss", "aa", "aa", "Overdue");
                booksReserved1.ReserveDataGridView.Rows.Add("hh" + i, "ddadsgdffffgdsfgsdgdfgdfgv", "ss" + (i * 7), "ss", "aa", "aa", "Not Overdue");
            }

        }

        private void FORM_REPORTS_Resize(object sender, EventArgs e)
        {
            monthlyOverview1.Width = LAYOUT_REPORT.ClientSize.Width - 30;
            booksReserved1.Width = LAYOUT_REPORT.ClientSize.Width - 30;
            booksBorrowed1.Width = LAYOUT_REPORT.ClientSize.Width - 30;


            monthlyOverview1.Height = LAYOUT_REPORT.ClientSize.Width /2;
            booksReserved1.Height = LAYOUT_REPORT.ClientSize.Width / 2;
            booksBorrowed1.Height = LAYOUT_REPORT.ClientSize.Width / 2;
        }
    }
}
