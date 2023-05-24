using HotelListing.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
