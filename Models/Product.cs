using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)] // Constraint to limit the name length.
        public string Name { get; set; } = string.Empty;

        [StringLength(500)] // Constraint to limit the description length.
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(0, double.MaxValue)] // Ensure price is non-negative.
        public decimal Price { get; set; } = 0.0M;

        // Foreign key for Category. 
        public int CategoryId { get; set; } = 0; // Default value of 0 implies no category is set.
        public Category? Category { get; set; } // Made nullable by appending the '?'

        // Constructor
        public Product()
        {
            // Initialize properties here if needed.
            // With the current setup, properties are already initialized above.
        }

        // ... (Any other properties or methods you might have) ...
    }
}
