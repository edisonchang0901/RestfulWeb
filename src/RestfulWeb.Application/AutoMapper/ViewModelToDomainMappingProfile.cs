using AutoMapper;
using RestfulWeb.Application.ViewModels;
using RestfulWeb.Domain.Models;

namespace RestfulWeb.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile() 
        {
            CreateMap<UserViewModel, User>();
        }
    }
}
