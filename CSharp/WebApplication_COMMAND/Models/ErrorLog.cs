namespace WebApplication_COMMAND.Models
{
    public class ErrorLog
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime Time { get; set; }
    }

}
