using Microsoft.Extensions.Options;
using RelTransCustomer.Application.Contracts.Services;
using RelTransCustomer.Application.DTOs.Email;
using RelTransCustomer.Application.Exceptions;
using RelTransCustomer.Application.Settings;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace RelTransCustomer.Shared.Services
{
    public class EmailService : IEmailService
    {
        public MailSetting _mailSettings { get; }

        public EmailService(IOptions<MailSetting> mailSettings)
        {
            _mailSettings = mailSettings.Value;

        }

        public async Task SendAsync(EmailRequest request)
        {
            try
            {
                var email = new MimeMessage();
                email.Sender = new MailboxAddress(_mailSettings.DisplayName, request.From ?? _mailSettings.EmailFrom);
                email.To.Add(MailboxAddress.Parse(request.To));
                email.Subject = request.Subject;
                var builder = new BodyBuilder();
                builder.HtmlBody = request.Body;
                email.Body = builder.ToMessageBody();
                using var smtp = new SmtpClient();
                smtp.Connect(_mailSettings.SmtpHost, _mailSettings.SmtpPort, SecureSocketOptions.None);
                smtp.Authenticate(_mailSettings.SmtpUsername, _mailSettings.SmtpPassword);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
            catch (System.Exception ex)
            {
                //_logger.LogError(ex.Message, ex);
                throw new ApiException(ex.Message);
            }
        }
    }
}