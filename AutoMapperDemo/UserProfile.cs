using AutoMapper;
using AutoMapperDemo.Dto;
using AutoMapperDemo.Models;

namespace AutoMapperDemo
{
    //As soon as our app starts, AutoMapper will scan our app for classes that inherit from Profile class and load their mapping configurations
    public class UserProfile: Profile       //Profile is an AutoMapper class
    {
        public UserProfile()
        {
            CreateMap<User, UserForUI>()
                .ForMember(dest => dest.FName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LName, opt => opt.MapFrom(src => src.LastName))
                .ReverseMap();      //This allows a reverse map...as the name suggests!
        }
    }
}
