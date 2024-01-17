using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.SERVICES
{
    public interface IEmailSender
    {
        void SendEmail(string recipientEmail, string subject, string body);
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
            smtpClient.Credentials = new NetworkCredential(Environment.GetEnvironmentVariable("SENDER_EMAIL"),
                Environment.GetEnvironmentVariable("SENDER_PASSWORD"));
            smtpClient.EnableSsl = true;

            // Send the email
            smtpClient.Send(mail);

            // Dispose of the SmtpClient and MailMessage objects
            smtpClient.Dispose();
            mail.Dispose();
        }
    }

}
