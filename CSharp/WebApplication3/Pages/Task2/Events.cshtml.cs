// Pages/Events/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Data.WebApplication3.Data;

namespace WebApplication3.Pages.Task2
{
    public class EventsModel : PageModel
    {
        private readonly AppDbContext _context;
        public EventsModel(AppDbContext context) => _context = context;

        public IList<Event> Events { get; set; }
        public string CurrentFilter { get; set; }
        public int CurrentPage { get; set; }

        public async Task OnGetAsync(string searchString, int pageNumber = 1)
        {
            // Проверка пустой таблицы Events и Participants
            if (!_context.Events.Any() && !_context.Participants.Any())
            {
                var participants = new List<Participant>();
                for (int i = 1; i <= 20; i++)
                {
                    participants.Add(new Participant { FullName = $"Participant {i}", Email = $"participant{i}@mail.com" });
                }
                _context.Participants.AddRange(participants);
                await _context.SaveChangesAsync();

                var random = new Random();
                for (int i = 1; i <= 20; i++)
                {
                    var ev = new Event
                    {
                        Title = $"Event {i}",
                        Date = DateTime.Now.AddDays(i),
                        Location = $"Location {i}"
                    };
                    _context.Events.Add(ev);
                    await _context.SaveChangesAsync();

                    // Рандомные участники для события
                    foreach (var p in participants.OrderBy(p => random.Next()).Take(5))
                    {
                        _context.EventParticipants.Add(new EventParticipant
                        {
                            EventId = ev.Id,
                            ParticipantId = p.Id
                        });
                    }
                    await _context.SaveChangesAsync();
                }
            }

            // Загрузка списка событий
            CurrentFilter = searchString;
            CurrentPage = pageNumber;

            var query = _context.Events
                .Include(e => e.EventParticipants)
                    .ThenInclude(ep => ep.Participant)
                .AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
                query = query.Where(e => e.Title.Contains(searchString) || e.Location.Contains(searchString));

            query = query.OrderByDescending(e => e.EventParticipants.Count);

            int pageSize = 10;
            Events = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
    }
}
