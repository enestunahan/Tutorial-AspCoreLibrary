using AutoMapper;
using FluentValidationApp.Web.Dtos;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.Mapping
{
    public class EventDateProfile : Profile
    {
        public EventDateProfile()
        {
            CreateMap<EventDateDto, EventDate>()
              .ForMember(dest => dest.Date, opt => opt.MapFrom(x => new DateTime(x.Year, x.Month, x.Day)));

            CreateMap<EventDate, EventDateDto>()
              .ForMember(dest => dest.Year, opt => opt.MapFrom(x => x.Date.Year))
              .ForMember(dest => dest.Month, opt => opt.MapFrom(x => x.Date.Month))
              .ForMember(dest => dest.Day, opt => opt.MapFrom(x => x.Date.Day));
        }
    }
}
