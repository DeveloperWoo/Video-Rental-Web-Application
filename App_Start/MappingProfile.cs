using AutoMapper;
using VideoRental.Dtos;
using VideoRental.Models;

namespace VideoRental.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {   
            //Domain to Dto
            //Mapper.CreateMap<Source, Target>();
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembrshipTypeDto>();

            //Dto to Domain
            /*
             * Id is the key property for the Movie(and Customer) class, and a key property should not be changed.
             * That’s why we get this exception. To resolve this, 
             * we need to tell AutoMapper to ignore Id during mapping of a MovieDto to Movie. 
             */
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>().ForMember(c => c.Id, opt => opt.Ignore());

        }
    }
}