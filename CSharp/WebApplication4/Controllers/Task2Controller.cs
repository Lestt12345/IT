using Microsoft.AspNetCore.Mvc;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class Task2Controller : Controller
    {
        private readonly DateTimeService _service;

        public Task2Controller()
        {
            _service = new DateTimeService();
        }

        public IActionResult Index()
        {
            ViewBag.Date = _service.Now();
            return View();
        }
    }
}