using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using SupposedlySecureApplication.Services;

namespace SupposedlySecureApplication.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(subject, message, email);
        }
        
        public readonly IOptions<Secrets> _secrets;

        public EmailSender(IOptions<Secrets> secrets)
        {
            _secrets = secrets;
        }

        public Task Execute(string subject, string message, string email)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.Credentials = new NetworkCredential(_secrets.Value.SmtpEmail, _secrets.Value.SmtpPassword);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            
            // do not use in production, disables checks for valid SSL certificate
            ServicePointManager.ServerCertificateValidationCallback =
                delegate {
                    return true;
                };

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(_secrets.Value.SmtpEmail, "SupposedlySecureApplication");
            mail.To.Add(new MailAddress(email));
            mail.Subject = subject;
            mail.Body = message;

            return smtpClient.SendMailAsync(mail);
        }
    }
}