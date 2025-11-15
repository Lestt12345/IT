using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class Task4Model : PageModel
    {
        private static readonly string[] Quotes =
        {
            "Секрет успіху — це почати.",
            "Вчитися ніколи не пізно.",
            "Кожна помилка — це крок до перемоги.",
            "Сьогодні — найкращий день, щоб почати.",
            "Мрій масштабно, працюй наполегливо."
        };

        public string RandomQuote { get; private set; }

        public void OnGet()
        {
            RandomQuote = Quotes[new Random().Next(Quotes.Length)];
        }
    }
}
