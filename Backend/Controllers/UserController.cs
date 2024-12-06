using Microsoft.AspNetCore.Mvc;

namespace SimplifiedBlaBlaCar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // Example: Endpoint for registering a user
        [HttpPost("register")]
        public IActionResult RegisterUser()
        {
            // Placeholder logic for registering a user
            return Ok("User registered successfully!");
        }

        // Example: Endpoint for logging in a user
        [HttpPost("login")]
        public IActionResult LoginUser()
        {
            // Placeholder logic for user login
            return Ok("User logged in successfully!");
        }
    }
}
