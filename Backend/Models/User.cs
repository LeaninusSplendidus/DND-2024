namespace SimplifiedBlaBlaCar.Models
{
    public class User
    {
        public int Id { get; set; } // Primary key

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; } // This will store the hashed password

        [Required]
        public string Role { get; set; } // "Driver" or "Passenger"
    }
}
