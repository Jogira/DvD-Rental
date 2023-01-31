using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Rental
    {
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Movie Movie { get; set; }

        public DateTime DateRented { get; set; }

        //Keep nullable because it's possible the movie hasn't been returned yet.
        public DateTime? DateReturned { get; set; }
        
    }
}