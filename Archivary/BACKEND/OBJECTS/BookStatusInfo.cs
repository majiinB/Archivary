using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.OBJECTS
{
    public class BookStatusInfo
    {
        public string Title { get; set; }
        public DateTime BorrowedAt { get; set; }
        public bool IsReturned { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime ReturnDueDate { get; set; }
        public string Status { get; set; }
    }
}
