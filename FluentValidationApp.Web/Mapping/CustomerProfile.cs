using AutoMapper;
using FluentValidationApp.Web.Dtos;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile() 
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.Isim, opt => opt.MapFrom(a => a.Name))
                .ForMember(dest => dest.Eposta, opt => opt.MapFrom(a => a.Email))
                .ForMember(dest => dest.Yas, opt => opt.MapFrom(a => a.Age))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(a => a.FullNameDeneme()))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(a => a.CreditCard.Number))
                .ForMember(dest => dest.ValidDate, opt => opt.MapFrom(a => a.CreditCard.ValidDate));

        }
    }
}
