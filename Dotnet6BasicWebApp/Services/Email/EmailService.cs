using Dotnet6BasicWebApp.Services.Email.Interfaces;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Dotnet6BasicWebApp.Data;

namespace Dotnet6BasicWebApp.Services.Email
{
    public class EmailService: IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;
        public EmailService(IConfiguration configuration, ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        public async Task SendEmailViaAppPass(string mailTo, string subject, string message)
        {
            string userName = _configuration["EmailSettings:Email"];
            string host = _configuration["EmailSettings:Host"];
            int port = int.Parse(_configuration["EmailSettings:Port"]);
            string mailFrom = _configuration["EmailSettings:Email"];
            string appPassword = _configuration["EmailSettings:AppPassword"];
            var emailMessage = new MailMessage();
            emailMessage.To.Add(new MailAddress(mailTo));
            emailMessage.From = new MailAddress(mailFrom, "Patient Management");
            emailMessage.Subject = subject;
            emailMessage.Body = message;
            emailMessage.IsBodyHtml = true;
            var credential = new NetworkCredential
            {
                UserName = userName,
                Password = appPassword
            };

            SmtpClient SmtpServer = new SmtpClient(host, port);
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.Timeout = 5000;
            SmtpServer.EnableSsl = true;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new NetworkCredential(mailFrom, appPassword);
            SmtpServer.Send(emailMessage);

            await Task.CompletedTask;
        }
    }
}
