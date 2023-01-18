﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min1MovieAvailable : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            var movie = (Movie)validationContext.ObjectInstance;
            if (movie.NumberInStock <= 0 ||
                movie.NumberInStock > 20)
            {
                return new ValidationResult("Only accepting 1-20 as input.");
            }

            return ValidationResult.Success;

        }
    }
}