using Microsoft.AspNetCore.Mvc;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class Task3Controller : Controller
    {
        private readonly RandomNumberService _service;

        public Task3Controller()
        {
            _service = new RandomNumberService();
        }

        public IActionResult Index()
        {
            ViewBag.Number = _service.Get();
            return View();
        }
    }
}