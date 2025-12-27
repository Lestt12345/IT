namespace WebApplication4.Services
{
    public class DateTimeService
    {
        public string Now()
        {
            return DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }
    }
}