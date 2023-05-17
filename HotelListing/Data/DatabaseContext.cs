using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        //COURSE: overriding this method to seed database with data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Poland",
                    ShortName = "PL",
                },
                new Country
                {
                    Id = 2,
                    Name = "United States",
                    ShortName = "US",
                },
                new Country
                {
                    Id = 3,
                    Name = "Jamaica",
                    ShortName = "JM",
                }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Polski Hotel",
                    Address = "Warszawa",
                    Raiting = 4,
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Cesar Palace",
                    Address = "Las Vegas",
                    Raiting = 4.7,
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Sandals Resort an Spa",
                    Address = "Negril",
                    Raiting = 4.1,
                    CountryId = 3
                }
                ); ;
        }
    }
}
