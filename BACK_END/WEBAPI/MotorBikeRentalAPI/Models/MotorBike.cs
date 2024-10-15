using Microsoft.VisualBasic.FileIO;
using System.Reflection;
using System.Security.Cryptography.Xml;

namespace MotorBikeRentalAPI.Models
{
    public class MotorBike
    {
        public string Registration_Number { get; set; }
        public int Category_Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Manufactured_Year { get; set; }
        public int Engine_Capacity { get; set; }
        public string Fuel_Type { get; set; }
        public decimal Daily_Rate { get; set; }
        public string Status { get; set; }
        public int Mile_Age { get; set; }
        public DateOnly Last_Serviced { get; set; }
        public string Insurance_Policy_Number { get; set; }
        public DateOnly Insurance_Expiry { get; set; }
    }
}
