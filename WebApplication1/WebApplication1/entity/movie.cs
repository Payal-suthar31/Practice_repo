using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace WebApplication1.entity
{
    public class movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        [Required]
        [Range(1, 100)]
        public int Price { get; set; }

        [ValidateNever]
        public general? general {  get; set; }
        public int generalid { get; set; }
        public DateOnly ReleaseDa { get; set; }
        
    }
}
