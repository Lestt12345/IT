using Microsoft.AspNetCore.Mvc;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class Task5Controller : Controller
    {
        private readonly IEmailService _service;

        public Task5Controller()
        {
            _service = new EmailService();
        }

        public IActionResult Index()
        {
            ViewBag.Result = _service.Send("test@mail.com");
            return View();
        }
    }
}