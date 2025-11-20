using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Pages
{
    public class Task3Model : PageModel
    {
        [BindProperty]
        [EmailAddress]
        public string Email { get; set; }

        public void OnGet() //asd
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            TempData["Success"] = "Subscribed!";
            return RedirectToPage("/Success");
        }
    }
}
