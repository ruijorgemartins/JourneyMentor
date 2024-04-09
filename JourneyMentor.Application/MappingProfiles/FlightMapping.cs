using AutoMapper;
using JourneyMentor.Application.Flight.Queries;
using JourneyMentor.Domain.Aggregates.FlightAggregate;

namespace JourneyMentor.Application.MappingProfiles
{
    internal class FlightMapping: Profile
    {
        public FlightMapping()
        {
            CreateMap<GetFlightsQuery, FlightResponse>();
        }
    }
}
