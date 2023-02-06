using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public byte? NumberInStock { get; set; }


        [Display(Name = "Number Available")]
        [Range(1, 20)]
        [Required]
        public byte? NumberAvailable { get; set; }


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


        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            NumberAvailable = movie.NumberInStock;
            GenreId = movie.GenreId;
            //PosterBinary = movie.PosterBinary;
            ImagePath = movie.ImagePath;
            ImageFile = movie.ImageFile;
            ImageName = movie.ImageName;
            ImageId = movie.ImageId;
        }
    }
}