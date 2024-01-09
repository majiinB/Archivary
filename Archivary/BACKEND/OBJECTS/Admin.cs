using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.OBJECTS
{
    public class Admin
    {
        public string AdminId { get; set; }
        public int AdminUserId { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string AdminMiddleName { get; set; }
        public string AdminEmail { get; set; }
        public string AdminAddress { get; set; }
        public string AdminContacNum { get; set; }
        public string AdminImagePath { get; set; }
        public string AdminStatus { get; set; }

        public Admin(string adminID, int adminUserId, string adminFirstName, string adminLastName, string adminMiddleName,
            string adminEmail, string adminAddress, string adminContacNum, string adminImagePath, string adminStatus)
        {
            AdminId = adminID;
            AdminUserId = adminUserId;
            AdminFirstName = adminFirstName;
            AdminLastName = adminLastName;
            AdminMiddleName = adminMiddleName;
            AdminEmail = adminEmail;
            AdminAddress = adminAddress;
            AdminContacNum = adminContacNum;
            AdminImagePath = adminImagePath;
            AdminStatus = adminStatus;
        }
    }
}
