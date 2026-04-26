using System.Configuration;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Text;

namespace project_mvc.Models
{
    public static class EmailService
    {
        public static void SendNewsletter(string toEmail, string subject, string htmlBody)
        {
            var smtpSection = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");

            var fromAddress = new MailAddress(smtpSection.From);
            var toAddress = new MailAddress(toEmail);

            using (var message = new MailMessage(fromAddress, toAddress))
            {
                message.Subject = subject;
                message.BodyEncoding = Encoding.UTF8;
                message.SubjectEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                message.Body = htmlBody;

                using (var client = new SmtpClient())
                {
                    client.Host = smtpSection.Network.Host;
                    client.Port = smtpSection.Network.Port;
                    client.EnableSsl = smtpSection.Network.EnableSsl;
                    client.Credentials = new NetworkCredential(
                        smtpSection.Network.UserName,
                        smtpSection.Network.Password
                    );

                    client.Send(message);
                }
            }
        }
    }
}