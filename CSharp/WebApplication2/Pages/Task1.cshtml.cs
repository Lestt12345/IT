using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Pages
{
    public class Task1Model : PageModel
    {
        [BindProperty]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [BindProperty]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [BindProperty]
        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        [BindProperty]
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [BindProperty]
        [Range(18, 100)]
        public int Age { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            TempData["seccess"] = "Registration complete!";
            return RedirectToPage("/Seccess");
        }
    }
}
