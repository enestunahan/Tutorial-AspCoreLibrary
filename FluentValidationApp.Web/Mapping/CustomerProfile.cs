using AutoMapper;
using FluentValidationApp.Web.Dtos;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile() 
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();

            // Yukarıdaki gibi yazmak yerine bu şekilde de yazabiliyoruz.
            //CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
