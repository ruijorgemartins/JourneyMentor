using JourneyMentor.Application.Flight.Queries;
using JourneyMentor.Dal;
using JourneyMentor.Domain.Aggregates.FlightAggregate;
using MediatR;
using MySqlX.XDevAPI;
using System.Net.Http;
using System.Text.Json;

namespace JourneyMentor.Application.Flight.QueryHandlers
{
    public class GetFlightsByAirlineQueryHandler : IRequestHandler<GetFlightsByAirlineQuery, FlightResponse>
    {
        private readonly DataContext _dataContext;

        public GetFlightsByAirlineQueryHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<FlightResponse> Handle(GetFlightsByAirlineQuery request, CancellationToken cancellationToken)
        {
            Helpers.InitializeClient();

            using HttpResponseMessage response = await Helpers.ApiClient.
                GetAsync($"flights/access_key={ApplicationResources.AccessKey}&airline_name={request.AirLineName}", cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync(cancellationToken);
                return await JsonSerializer.DeserializeAsync<FlightResponse>(stream, cancellationToken: cancellationToken);
            }

            return null;
        }
    }   
}
    