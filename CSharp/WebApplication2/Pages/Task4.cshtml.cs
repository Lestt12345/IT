using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class Task4Model : PageModel
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Page { get; set; }

        public void OnGet(int id, string color, int page_)
        {
            Id = id;
            Color = color;
            Page = page_;
        }
    }
}
