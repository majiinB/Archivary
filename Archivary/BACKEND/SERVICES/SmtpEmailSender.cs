using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Archivary.BACKEND.OBJECTS;

namespace Archivary.BACKEND.SERVICES
{
    public interface IEmailSender
    {
        void SendEmail(string recipientEmail, string subject, string body);
        string EmployeeCreationMessage(string employeeName, string employeePass);
    }

    public class SmtpEmailSender : IEmailSender
    {
        private readonly string _senderEmail;
        private readonly string _senderPassword;

        public SmtpEmailSender(string senderEmail, string senderPassword)
        {
            _senderEmail = senderEmail;
            _senderPassword = senderPassword;
        }

        public void SendEmail(string recipientEmail, string subject, string body)
        {
            // Create a new MailMessage
            MailMessage mail = new MailMessage(_senderEmail, recipientEmail);
            mail.Subject = subject;
            mail.Body = body;

            // Create a new SmtpClient
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

            // Set the port and credentials
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential(_senderEmail, _senderPassword);
            smtpClient.EnableSsl = true;

            // Send the email
            smtpClient.Send(mail);

            // Dispose of the SmtpClient and MailMessage objects
            smtpClient.Dispose();
            mail.Dispose();
        }

        public string EmployeeCreationMessage(string employeeName, string employeePass)
        {
            string librarianEmailTemplate = @"
                Dear [LibrarianName],

                Welcome to our library system! Your account has been created successfully.

                Account Details:
                - Librarian Name: [LibrarianName]
                - Account Password: [Password]

                Please keep your login information confidential. If you have any questions or concerns, feel free to contact our support team.

                Best regards,
                Archivary Libarary Management System
                ";

            string emailBody = librarianEmailTemplate
                .Replace("[LibrarianName]", employeeName)
                .Replace("[Password]", employeePass);

            return emailBody;


        }
    }

}
