namespace WebApplication4.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from service";
        }
    }
}