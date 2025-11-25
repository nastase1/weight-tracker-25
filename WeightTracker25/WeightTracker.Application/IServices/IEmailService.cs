
namespace WeightTracker.Application.IServices
{
    public interface IEmailService
    {
        Task SendEmailAsync(string to, string subject, string body, bool isBodyHtml = false);
        Task SendWelcomeEmailAsync(string email, string firstName);
        Task SendPasswordResetCodeAsync(string email, string firstName, string resetCode);
    }
}