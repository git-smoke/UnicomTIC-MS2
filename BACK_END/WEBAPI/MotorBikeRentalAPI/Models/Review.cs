using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;

namespace MotorBikeRentalAPI.Models
{
    public class Review
    {
        public int Review_Id { get; set; }
        public int Rental_Id { get; set; }
        public int Nic_Number { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateOnly Review_Date { get; set; }
        public bool Is_Approved { get; set; }
    }
}
