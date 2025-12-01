namespace WebApplication_COMMAND.Models
{
    public class RequestLog
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string HttpMethod { get; set; }
        public string UserEmail { get; set; }
        public long DurationMs { get; set; }
        public DateTime Time { get; set; }
    }

}
