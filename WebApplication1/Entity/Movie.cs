using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using WebApplication1.entity;

namespace WebApplication1.Entity

{

    public class Movie

    {

        public int Id { get; set; }

        [Required]

        [StringLength(100)]

        public required string Name { get; set; }

        [Required]

        [Range(1, 100)]

        public int Price { get; set; }

        [ValidateNever]

        public Genre? Genre { get; set; }

        public int General_Id { get; set; }

        public DateOnly ReleaseDate { get; set; }

    }

}

