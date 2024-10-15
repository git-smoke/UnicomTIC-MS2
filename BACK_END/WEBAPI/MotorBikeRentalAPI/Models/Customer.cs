using System.Diagnostics.Metrics;
using System.Net;
using System.Security.Cryptography.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MotorBikeRentalAPI.Models
{
    public class Customer
    {
        public string Nic_Number { get; set; }
        public int User_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string postal_Code { get; set; }
        public string Date_Of_Birth { get; set; }
        public string Driving_License_Number { get; set; }
        public string Driving_License_Expiry { get; set; }
        public DateOnly Registration_Date { get; set; }
        public bool Is_BlackListed { get; set; }
        public string Blacklist_Reason { get; set; }
    }
}