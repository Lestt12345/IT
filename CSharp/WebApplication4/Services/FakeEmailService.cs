namespace WebApplication4.Services
{
    public class FakeEmailService : IEmailService
    {
        public string Send(string to)
        {
            return "Test email sent";
        }
    }
}