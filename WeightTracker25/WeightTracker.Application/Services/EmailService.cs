using WeightTracker.Application.IServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Mail;

namespace WeightTracker.Application.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<EmailService> _logger;

        public EmailService(IConfiguration configuration, ILogger<EmailService> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body, bool isBodyHtml = false)
        {
            try
            {
                var smtpSettings = _configuration.GetSection("SmtpSettings");

                using var client = new SmtpClient(smtpSettings["Host"], int.Parse(smtpSettings["Port"]))
                {
                    Credentials = new NetworkCredential(smtpSettings["Username"], smtpSettings["Password"]),
                    EnableSsl = bool.Parse(smtpSettings["EnableSsl"])
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(smtpSettings["FromEmail"], smtpSettings["FromName"]),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = isBodyHtml
                };

                mailMessage.To.Add(toEmail);

                await client.SendMailAsync(mailMessage);
                _logger.LogInformation($"Email sent successfully to {toEmail}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error sending email to {toEmail}: {ex.Message}");
                throw;
            }
        }

        public async Task SendWelcomeEmailAsync(string email, string firstName)
        {
            var subject = "Your account has been created -  Weight Tracker";

            var body = $@"
        <!DOCTYPE html>
        <html>
        <head>
            <style>
                body {{ font-family: Arial, sans-serif; }}
                .container {{ max-width: 600px; margin: 0 auto; padding: 20px; }}
                .header {{ background-color: #f8f9fa; padding: 20px; text-align: center; }}
                .content {{ padding: 20px; }}
                .warning {{ 
                    background-color: #fff3cd; 
                    border: 1px solid #ffeaa7; 
                    padding: 15px; 
                    margin: 20px 0; 
                    border-radius: 5px;
                }}
                .footer {{ 
                    background-color: #f8f9fa; 
                    padding: 15px; 
                    text-align: center; 
                    font-size: 12px; 
                    color: #6c757d;
                }}
            </style>
        </head>
        <body>
            <div class='container'>
                <div class='header'>
                    <h2>Welcome to Weight Tracker!</h2>
                </div>
        
                <div class='content'>
                    <p>Hello <strong>{firstName}</strong>,</p>
            
                    <p>Your account has been successfully created in the Weight Tracker application.</p>
            
                    <p><strong>Account details:</strong></p>
                    <ul>
                        <li><strong>Email:</strong> {email}</li>
                    </ul>
            
                    <div class='warning'>
                        <strong>Important:</strong> Please keep your account details secure and do not share them with anyone.
            
                    <p>If you have any questions or issues, please contact the system administrator.</p>
            
                    <p>Best regards,<br>The Weight Tracker Administration Team</p>
                </div>
        
                <div class='footer'>
                    <p>This email was generated automatically. Please do not reply to this message.</p>
                </div>
            </div>
        </body>
        </html>";

            await SendEmailAsync(email, subject, body, true);
        }

        public async Task SendPasswordResetCodeAsync(string email, string firstName, string resetCode)
        {
            var subject = "Password Reset Code - Weight Tracker";

            var body = $@"
        <!DOCTYPE html>
        <html>
        <head>
            <style>
                body {{ font-family: Arial, sans-serif; }}
                .container {{ max-width: 600px; margin: 0 auto; padding: 20px; }}
                .header {{ background-color: #f8f9fa; padding: 20px; text-align: center; }}
                .content {{ padding: 20px; }}
                .code-box {{ 
                    background-color: #e9ecef; 
                    border: 1px solid #ced4da; 
                    padding: 15px; 
                    margin: 20px 0; 
                    font-family: monospace; 
                    font-size: 24px;
                    text-align: center;
                    border-radius: 5px;
                    letter-spacing: 2px;
                }}
                .warning {{ 
                    background-color: #fff3cd; 
                    border: 1px solid #ffeaa7; 
                    padding: 15px; 
                    margin: 20px 0; 
                    border-radius: 5px;
                }}
                .footer {{ 
                    background-color: #f8f9fa; 
                    padding: 15px; 
                    text-align: center; 
                    font-size: 12px; 
                    color: #6c757d;
                }}
            </style>
        </head>
        <body>
            <div class='container'>
                <div class='header'>
                    <h2>Password Reset - Weight Tracker</h2>
                </div>
        
                <div class='content'>
                    <p>Hello <strong>{firstName}</strong>,</p>
            
                    <p>You have requested to reset your password.</p>
            
                    <p><strong>Your verification code:</strong></p>
            
                    <div class='code-box'>
                        {resetCode}
                    </div>
            
                    <div class='warning'>
                        <strong>Important:</strong> This code is valid for 15 minutes only.
                    </div>
            
                    <p>Use this code on the reset password page to set your new password.</p>
            
                    <p>If you did not request this password reset, please ignore this email.</p>
            
                    <p>Best regards,<br>The Weight Tracker Team</p>
                </div>
        
                <div class='footer'>
                    <p>This email was generated automatically. Please do not reply to this message.</p>
                </div>
            </div>
        </body>
        </html>";

            await SendEmailAsync(email, subject, body, true);
        }
    }
}