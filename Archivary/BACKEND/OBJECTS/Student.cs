using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.OBJECTS
{
    public class Student
    {
        public string StudentId { get; set; }
        public int StudentUserId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentMiddleName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentDepartment { get; set; }
        public int StudentYearLevel { get; set; }
        public string StudentSection { get; set; }
        public string StudentAddress { get; set; }
        public string StudentContactNum { get; set; }
        public string StudentImagePath { get; set; }
        public string StudentStatus { get; set; }

        public Student(string studentID, int studentUserId, string studentFirstName, string studentLastName, string studentMiddleName,
            string studentEmail, string studentDepartment, int studentYearLevel, string studentSection, string studentAddress,
            string studentContactNum, string studentImagePath, string studentStatus)
        {
            StudentId = studentID;
            StudentUserId = studentUserId;
            StudentFirstName = studentFirstName;
            StudentLastName = studentLastName;
            StudentMiddleName = studentMiddleName;
            StudentEmail = studentEmail;
            StudentDepartment = studentDepartment;
            StudentYearLevel = studentYearLevel;
            StudentSection = studentSection;
            StudentAddress = studentAddress;
            StudentContactNum = studentContactNum;
            StudentImagePath = studentImagePath;
            StudentStatus = studentStatus;
        }
    }
}
