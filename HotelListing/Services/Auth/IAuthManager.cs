using HotelListing.Models.User;

namespace HotelListing.Services.Auth
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDTO userDTO);
        Task<string> CreateToken();
    }
}
