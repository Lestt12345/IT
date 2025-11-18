using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class Task2Model : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = "Hello";
        }
    }
}
