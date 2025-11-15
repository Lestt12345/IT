using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class Task2Model : PageModel
    {
        public int RandomNumber { get; set; }

        public void OnGet()
        {
            RandomNumber = new Random().Next(1, 101);
        }
    }
}
