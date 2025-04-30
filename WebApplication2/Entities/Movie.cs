using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1, 100)]
        public decimal Price { get; set; }

        // Foreign key
        public int GenreId { get; set; }

        // Navigation property
        [ValidateNever]
        public Genre? Genre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
