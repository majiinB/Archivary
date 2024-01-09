using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.OBJECTS
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public int EmployeeUserId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeMiddleName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeContactNum { get; set; }
        public string EmployeeImagePath { get; set; }
        public string EmployeeStatus { get; set; }
        public Employee(string employeeId, int employeeUserId, string employeeFirstName, string employeeLastName,
            string employeeMiddleName, string employeeEmail, string employeeAddress, string employeeContactNum, string employeeImagePath, string employeeStatus)
        {
            EmployeeId = employeeId;
            EmployeeUserId = employeeUserId;
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            EmployeeMiddleName = employeeMiddleName;
            EmployeeEmail = employeeEmail;
            EmployeeAddress = employeeAddress;
            EmployeeContactNum = employeeContactNum;
            EmployeeImagePath = employeeImagePath;
            EmployeeStatus = employeeStatus;
        }
    }
}
