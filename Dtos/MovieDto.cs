using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

 
        public string Name { get; set; }

        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }


        public DateTime ReleaseDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }


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