using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        
        public DbSet<AirlineCompany> AirlineCompanies { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<AirplaneChanges> AirplaneChanges { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Luggage> Luggages { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Employees> Employee { get; set; }
    }
}
