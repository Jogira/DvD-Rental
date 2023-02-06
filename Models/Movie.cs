
using Elmah.ContentSyndication;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;


namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Min1MovieAvailable]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }


        //[Column(TypeName = "varbinary")]
        //public Byte[] PosterBinary { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string ImagePath { get; set; }

        public int ImageId { get; set; }

        public string ImageName { get; set; }

        [NotMapped]
        [Display(Name = "Upload Movie Cover")]
        public HttpPostedFileBase ImageFile { get; set; }

    }
}