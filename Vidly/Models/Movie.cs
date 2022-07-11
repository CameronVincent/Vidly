using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Display(Name="Genre")]
        public int GenreId { get; set; }

        [Required]
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        public byte NumberInStock { get; set; }
    }
}