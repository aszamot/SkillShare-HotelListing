using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.Hotel
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel name is to long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Hotel address is to long")]
        public string Address { get; set; }
        [Required]
        [Range(0,5)]
        public double Raiting { get; set; }
        [Required]
        public int CountryId { get; set; }
    }
}
