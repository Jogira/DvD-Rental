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
            //Domain to DTO.
            CreateMap<Customer, CustomerDto>();
            //DTO to domain.
            CreateMap<CustomerDto, Customer>();

            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>();

            CreateMap<MembershipType, MembershipTypeDto>();
            CreateMap<MembershipTypeDto, MembershipType>();


        }
    }

}



