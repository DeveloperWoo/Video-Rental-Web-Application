using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRental.Dtos;
using VideoRental.Models;

namespace VideoRental.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {   
            //Mapper.CreateMap<Source, Target>();
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}