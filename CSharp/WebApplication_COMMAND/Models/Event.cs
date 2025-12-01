namespace WebApplication_COMMAND.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int OrganizerId { get; set; }
        public User Organizer { get; set; }

        public ICollection<Registration> Registrations { get; set; }
    }

}
