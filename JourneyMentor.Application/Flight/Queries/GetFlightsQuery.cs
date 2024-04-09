using JourneyMentor.Domain.Aggregates.FlightAggregate;
using MediatR;

namespace JourneyMentor.Application.Flight.Queries
{
    public class GetFlightsQuery : IRequest<FlightResponse>
    {
    }
}
        