using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using Vidly.Dtos;
using System.Security.Cryptography;
using AutoMapper;
using Microsoft.Ajax.Utilities;

namespace Vidly.App_Start
{

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();

            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>();
        }
    }

}



