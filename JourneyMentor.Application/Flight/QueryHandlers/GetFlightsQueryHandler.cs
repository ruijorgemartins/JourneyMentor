using JourneyMentor.Application.Flight.Queries;
using JourneyMentor.Dal;
using JourneyMentor.Domain.Aggregates.FlightAggregate;
using MediatR;
using Mysqlx;
using MySqlX.XDevAPI;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text.Json;

namespace JourneyMentor.Application.Flight.QueryHandlers
{
    public class GetFlightsQueryHandler : IRequestHandler<GetFlightsQuery, FlightResponse>
    {
        private readonly DataContext _dataContext;

        public GetFlightsQueryHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<FlightResponse> Handle(GetFlightsQuery request, CancellationToken cancellationToken)
        {

            Helpers.InitializeClient();

            using HttpResponseMessage response = await Helpers.ApiClient.
                GetAsync($"flights/access_key={ApplicationResources.AccessKey}", cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync(cancellationToken);
                var flightResponse = await JsonSerializer.DeserializeAsync<FlightResponse>(stream, cancellationToken: cancellationToken);
            }

            return null;
        }
    }   
}
    