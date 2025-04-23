using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Models;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly StoreDBContext _context;

        public AuthController(StoreDBContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == loginRequest.Email);

            if (user == null || !user.VerifyPassword(loginRequest.Password))
            {
                return Unauthorized(new { success = false, message = "Неверные учетные данные" });
            }

            return Ok(new { success = true, message = "Вход выполнен успешно" });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
        {
            if (_context.Users.Any(u => u.Username == registerRequest.Username))
            {
                return BadRequest(new { success = false, message = "Этот логин уже используется" });
            }

            var user = new User
            {
                Username = registerRequest.Username,
                Email = registerRequest.Email,
            };
            user.SetPassword(registerRequest.Password);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(new { success = true, message = "Пользователь успешно зарегистрирован" });
        }
    }
}
