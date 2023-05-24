using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HotelListing.Data;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
                );
        }
    }
}