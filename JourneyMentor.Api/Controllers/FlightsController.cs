using AutoMapper;
using JourneyMentor.Api.Contracts.Flights.Responses;
using JourneyMentor.Application.Flight.Queries;
using JourneyMentor.Domain.Aggregates.FlightAggregate;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JourneyMentor.Api.Controllers
{
    [ApiController]
    [Route(ApiRoutes.BaseRoute)]
    public class FlightsController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public FlightsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetFlights()
        {
            var query = new GetFlightsQuery();
            var response = await _mediator.Send(query);


            return Ok();
        }

        [HttpGet]
        [Route("{airline}")]
        public async Task<IActionResult> GetFlightsByAirline(string airline)
        {
            var query = new GetFlightsByAirlineQuery { AirLineName = airline };
            var response = await _mediator.Send(query);

            return Ok(response);
        }
    }
}
