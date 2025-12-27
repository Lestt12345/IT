using Microsoft.AspNetCore.Mvc;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class Task4Controller : Controller
    {
        private readonly CalculatorService _service;

        public Task4Controller()
        {
            _service = new CalculatorService();
        }

        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(int a, int b)
        {
            ViewBag.Sum = _service.Add(a, b);
            ViewBag.Div = _service.Divide(a, b);
            return View();
        }
    }
}