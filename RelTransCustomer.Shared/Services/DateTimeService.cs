using RelTransCustomer.Application.Contracts.Services;

namespace RelTransCustomer.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime CurrentDateTime => DateTime.Now;
    }
}