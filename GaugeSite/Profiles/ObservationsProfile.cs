using AutoMapper;
using Gauge.DTOs;
using Gauge.Models;

namespace Gauge.Profiles
{
    public class ObservationsProfile : Profile
    {
        public ObservationsProfile()
        {
            CreateMap<Observation, ObservationRead>();
        }   
    }
}