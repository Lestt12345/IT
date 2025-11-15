using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class Task5Model : PageModel
    {
        public class ContactForm
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Message { get; set; }
        }

        [BindProperty]
        public ContactForm CF { get; set; } = new();

        public void OnPost()
        {
            
        }
    }
}
