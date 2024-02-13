using System.Threading.Tasks;

namespace Dotnet6BasicWebApp.Services.Email.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailViaAppPass(string mailTo, string subject, string message);
    }
}
