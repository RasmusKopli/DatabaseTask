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
        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Guests> Guests { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<ServiceOrder> ServiceOrders { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Payroll> Payrolls { get; set; }
    }
}
