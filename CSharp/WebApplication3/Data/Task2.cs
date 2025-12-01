namespace WebApplication3.Data
{
    using System;
    using System.Collections.Generic;

    namespace WebApplication3.Data
    {
        public class Event
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public DateTime Date { get; set; }
            public string Location { get; set; }
            public ICollection<EventParticipant> EventParticipants { get; set; }
        }

        public class Participant
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public ICollection<EventParticipant> EventParticipants { get; set; }
        }

        public class EventParticipant
        {
            public int EventId { get; set; }
            public Event Event { get; set; }

            public int ParticipantId { get; set; }
            public Participant Participant { get; set; }
        }
    }
}