using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
    
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Column(TypeName="nvarchar(50")]
        public string Title { get; set; }
    
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
    
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}