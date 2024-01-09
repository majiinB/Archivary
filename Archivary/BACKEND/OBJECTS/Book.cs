using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.OBJECTS
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookGenre { get; set; }
        public string BookAuthor { get; set; }
        public string BookISBN { get; set; }
        public string BookCategory { get; set; }
        public string BookCopyright { get; set; }
        public string BookPublisher { get; set; }
        public string BookStatus { get; set; }
        public int BookAisle { get; set; }
        public int BookShelf { get; set; }
        public string BookImage { get; set; }
        public Book(int bookId, string bookTitle, string bookGenre, string bookAuthor, string bookISBN, string bookCategory,
            string bookCopyright, string bookPublisher, string bookStatus, int bookAisle, int bookShelf, string bookImage)
        {
            BookId = bookId;
            BookTitle = bookTitle;
            BookGenre = bookGenre;
            BookAuthor = bookAuthor;
            BookISBN = bookISBN;
            BookCategory = bookCategory;
            BookCopyright = bookCopyright;
            BookPublisher = bookPublisher;
            BookStatus = bookStatus;
            BookAisle = bookAisle;
            BookShelf = bookShelf;
            BookImage = bookImage;
        }
    }
}
