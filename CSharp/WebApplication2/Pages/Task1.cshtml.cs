using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class Task1Model : PageModel
    {
        public string Message { get; set; }

        public void OnGet(string message)
        {
            Message = message;
        }

    }
}
