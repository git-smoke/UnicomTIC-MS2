namespace MotorBikeRentalAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password_Hash { get; set; }
        public string Email { get; set; }
        public string User_Type { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Last_Login { get; set; }
        public string Is_Active { get; set; }
       
    }
}
