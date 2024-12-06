namespace SimplifiedBlaBlaCar.Models
{
    public class User
    {
        public int Id { get; set; } // Primary key
        public string Name { get; set; } // User's name
        public string Email { get; set; } // User's email (used for login)
        public string Password { get; set; } // Hashed password
        public string Role { get; set; } // Role: "Driver" or "Passenger"
    }
}
