using Microsoft.Extensions.Logging;

namespace WebApplication_COMMAND.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public ICollection<Event> EventsOrganized { get; set; }
        public ICollection<Registration> Registrations { get; set; }
    }

}
