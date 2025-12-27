using Microsoft.AspNetCore.Mvc;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class Task1Controller : Controller
    {
        private readonly IMessageService _service;

        public Task1Controller()
        {
            _service = new MessageService();
        }

        public IActionResult Index()
        {
            ViewBag.Message = _service.GetMessage();
            return View();
        }
    }
}