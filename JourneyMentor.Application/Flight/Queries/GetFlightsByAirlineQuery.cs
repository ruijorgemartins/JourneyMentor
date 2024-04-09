using JourneyMentor.Domain.Aggregates.FlightAggregate;
using MediatR;

namespace JourneyMentor.Application.Flight.Queries
{
    public class GetFlightsByAirlineQuery : IRequest<FlightResponse>
    {
        public string AirLineName { get; set; }
    }
}
        