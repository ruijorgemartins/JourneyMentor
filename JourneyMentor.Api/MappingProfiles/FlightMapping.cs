using AutoMapper;
using JourneyMentor.Api.Contracts.Flights.Responses;
using JourneyMentor.Application.Flight.Queries;

namespace JourneyMentor.Api.MappingProfiles
{
    public class FlightMapping : Profile
    {
        public FlightMapping()
        {
            CreateMap<FlightResponse, GetFlightsQuery>();
        }
    }
}
