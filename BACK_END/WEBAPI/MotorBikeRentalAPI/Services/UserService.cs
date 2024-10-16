using MotorBikeRentalAPI.DTOs.UserDTO;
using MotorBikeRentalAPI.IRepositories;
using MotorBikeRentalAPI.IServices;
using MotorBikeRentalAPI.Models;

namespace MotorBikeRentalAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        // Hardcoded admin credentials
        private const string AdminUsername = "admin";
        private const string AdminPassword = "admin123";
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public int RegisterUser(User user)
        {
            user.Created_Date = DateTime.Now;
            user.Is_Active = true;
            return _userRepository.AddUser(user);
        }

        public User Authenticate(string username, string password)
        {
            if (username == AdminUsername && password == AdminPassword)
            {
                return new User { UserName = AdminUsername, User_Type = "Admin" };
            }
            var user = _userRepository.GetUserByUsername(username);
            if (user != null && user.Password_Hash == password)
            {
                return user;
            }
            return null;
        }

        public void UpdateLastLogin(int userId)
        {
            _userRepository.UpdateLastLogin(userId);
        }
    }
}
