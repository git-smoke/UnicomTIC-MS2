using MotorBikeRentalAPI.Models;

namespace MotorBikeRentalAPI.IServices
{
    public interface IUserService
    {
        int RegisterUser(User user);
        User Authenticate(string username, string password);
        void UpdateLastLogin(int userId);
    }
}
