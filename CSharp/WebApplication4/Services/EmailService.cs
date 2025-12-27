namespace WebApplication4.Services
{
    public class EmailService : IEmailService
    {
        public string Send(string to) => "Email sent to " + to;
    }
}
