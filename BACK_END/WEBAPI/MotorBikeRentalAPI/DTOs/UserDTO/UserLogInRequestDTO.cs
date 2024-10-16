namespace MotorBikeRentalAPI.DTOs.UserDTO
{
    public class UserLogInRequestDTO
    {
        public string UserName { get; set; }
        public string Password_Hash { get; set; }
    }
}
