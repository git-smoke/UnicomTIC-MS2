using System.Security.Cryptography.Xml;

namespace MotorBikeRentalAPI.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public string Nic_Number { get; set; }
        public DateTime Rent_Date { get; set; }
        public DateTime Due_Date { get; set; }
        public string Status { get; set; }
        public decimal Total_Cost { get; set; }
        public decimal Deposit_Amount { get; set; }
        public string Pickup_Location { get; set; }
        public string Return_Location { get; set; }
        public int Initial_Milage { get; set; }
        public int Return_Milage { get; set; }
        public string Damage_Notes { get; set; }
        public decimal Additional_Charges { get; set; }
        public decimal Payment_Method { get; set; }
        public string Payment_Status { get; set; }
    }
}
