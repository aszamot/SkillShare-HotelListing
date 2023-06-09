﻿using HotelListing.Models.Country;
using HotelListing.Models.Hotel;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }

        public IList<HotelDTO> Hotels { get; set; }
    }
}
