using AutoMapper;
using Gauge.DTOs;
using Gauge.Models;

namespace Gauge.Profiles
{
    public class DateStatProfile : Profile
    {
        public DateStatProfile()
        {            
            CreateMap<DateStat, DateStatRead>();
            CreateMap<DateStatCreateDTO, DateStat>();
        }   
    }
}