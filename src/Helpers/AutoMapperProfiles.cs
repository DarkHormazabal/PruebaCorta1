using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace PruebaCorta1.src.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles(){
            //added
            //CreateMap<ObjectOrigin, ObjectDestination>()
                //.ForMember(dest => dest.role, opt => opt.MapFrom(src => src.role.name)) ORM EXAMPLES
                //.ForMember(dest => dest.birth, opt => opt.MapFrom(src => DateOnly.ParseExact(src.birth, "dd/MM/yyyy"))); using dates
                
                
        }
}