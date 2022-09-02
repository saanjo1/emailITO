using Data.Entities;
using EmailAppITO.ViewModels;
using AutoMapper;

namespace EmailAppITO.MappingProfiles
{
    public class EmailProfile : Profile
    {
        public EmailProfile()
        {
            CreateMap<Email, EmailManageViewModel>().ReverseMap();
        }
    }
}
