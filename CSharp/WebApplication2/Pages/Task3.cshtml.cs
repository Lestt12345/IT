using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class Task3Model : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
    }
}
