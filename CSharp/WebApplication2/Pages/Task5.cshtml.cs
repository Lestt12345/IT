using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class Task5Model : PageModel
    {
        [BindProperty]
        public string Message { get; set; }

        public void OnPost()
        {
            ViewData["Message"] = Message;
        }
    }
}
