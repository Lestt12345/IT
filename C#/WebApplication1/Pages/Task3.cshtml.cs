using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class Task3Model : PageModel
    {
        public int OnCelsius { get; set; }
        public int OnFarenheit { get; set; }

        public void OnPost(int tempOnCelsius)
        {
            OnCelsius = tempOnCelsius;
            OnFarenheit = (tempOnCelsius * 9 / 5) + 32;
        }
    }
}
