using Microsoft.AspNetCore.Mvc;
using SimplifiedBlaBlaCar.Data;
using SimplifiedBlaBlaCar.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace SimplifiedBlaBlaCar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserController(ApplicationDbContext context, IPasswordHasher<User> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] User user)
        {
            // Validate the input data
            if (string.IsNullOrEmpty(user.Name) ||
                string.IsNullOrEmpty(user.Email) ||
                string.IsNullOrEmpty(user.Password) ||
                string.IsNullOrEmpty(user.Role))
            {
                return BadRequest("All fields are required.");
            }

            // Check if the email already exists
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
            if (existingUser != null)
            {
                return BadRequest("An account with this email already exists.");
            }

            // Hash the password securely
            user.Password = _passwordHasher.HashPassword(user, user.Password);

            // Save the user to the database
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok("User registered successfully!");
        }

        // Existing login method...
    }
}
