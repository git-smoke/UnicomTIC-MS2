using MotorBikeRentalAPI.Models;

namespace MotorBikeRentalAPI.IRepositories
{
    public interface IUserRepository
    {
        User GetUserByUsername(string username);
        void UpdateLastLogin(int userId);
        int AddUser(User user);

    }
}
