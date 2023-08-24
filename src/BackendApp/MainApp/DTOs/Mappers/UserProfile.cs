using AutoMapper;
using OmniAPI.Domain.Models;
using System.Net;

namespace OmniAPI.Main.DTOs.Mappers
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            this.CreateMap<User, LoginDTO>();
            this.CreateMap<LoginDTO, User>();
            this.CreateMap<User, RegisterDTO>();
            this.CreateMap<RegisterDTO, User>();
        }
    }
}
