using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.OBJECTS
{
    public class BookReportsInfo
    {
        public string userId { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public DateTime obtainedDate { get; set; }
        public DateTime dueDate { get; set; }
        public string status { get; set; }
    }
}
