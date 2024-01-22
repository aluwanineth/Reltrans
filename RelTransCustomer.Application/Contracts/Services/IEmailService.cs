using RelTransCustomer.Application.DTOs.Email;

namespace RelTransCustomer.Application.Contracts.Services;

public interface IEmailService
{
    Task SendAsync(EmailRequest request);
}
