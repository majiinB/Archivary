using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.OBJECTS
{
    public class Teacher
    {
        public string TeacherId { get; set; }
        public int TeacherUserId { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public string TeacherMiddleName { get; set; }
        public string TeacherEmail { get; set; }
        public string TeacherAddress { get; set; }
        public string TeacherContactNum { get; set; }
        public string TeacherDepartment { get; set; }
        public string TeacherImagePath { get; set; }
        public string TeacherStatus { get; set; }
        public Teacher(string teacherId, int teacherUserId, string teacherFirstName, string teacherLastName, string teacherMiddleName,
            string teacherEmail, string teacherAddress, string teacherContactNum, string teacherDepartment, string teacherImagePath, string teacherStatus)
        {
            TeacherId = teacherId;
            TeacherUserId = teacherUserId;
            TeacherFirstName = teacherFirstName;
            TeacherLastName = teacherLastName;
            TeacherMiddleName = teacherMiddleName;
            TeacherEmail = teacherEmail;
            TeacherAddress = teacherAddress;
            TeacherContactNum = teacherContactNum;
            TeacherDepartment = teacherDepartment;
            TeacherImagePath = teacherImagePath;
            TeacherStatus = teacherStatus;
        }
    }
}
