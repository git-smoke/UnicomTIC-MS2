using System.Security.Cryptography.Xml;

namespace MotorBikeRentalAPI.Models
{
    public class WaitList
    {
        public int Id { get; set; }
        public string Nic_Number { get; set; }
        public string Registration_Number { get; set; }
        public DateTime Request_Date { get; set; }
        public DateTime Expiry_Date { get; set; }
        public string Status { get; set; }
        public int Position_In_Queue { get; set; }
    }
}
