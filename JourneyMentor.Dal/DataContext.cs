using JourneyMentor.Domain.Aggregates.AirportAggregate;
using JourneyMentor.Domain.Aggregates.FlightAggregate;
using Microsoft.EntityFrameworkCore;

namespace JourneyMentor.Dal
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Airport> Airport { get; set; }
        public DbSet<Aircraft> Aircraft { get; set; }
        public DbSet<Live> Live { get; set; }
        public DbSet<Departure> Departure { get; set; }
        public DbSet<Arrival> Arrival { get; set; }
        public DbSet<Airline> Airline { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Codeshared> Codeshared { get; set; }
        public DbSet<Flights> Flights { get; set; }
    }
}
