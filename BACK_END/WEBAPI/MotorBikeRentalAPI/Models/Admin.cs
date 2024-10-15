using System.Security.Cryptography.Xml;

namespace MotorBikeRentalAPI.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public int Users_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Phone_Number { get; set; }
        public string Emergency_Contact { get; set; }
        public DateOnly Hire_Date { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
    }
}
