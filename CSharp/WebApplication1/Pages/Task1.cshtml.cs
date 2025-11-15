using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class Task1Model : PageModel
    {
        public DateTime CurrentDateTime { get; set; }

        public void OnGet()
        {
            CurrentDateTime = DateTime.Now;
        }
    }
}
