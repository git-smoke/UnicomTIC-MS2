using Microsoft.Extensions.Hosting;
using System.Security.Cryptography.Xml;

namespace MotorBikeRentalAPI.Models
{
    public class Maintenance
    {
        public int Id { get; set; }
        public string Registration_Number { get; set; }
        public DateOnly Maintenance_Date { get; set; }
        public string Maintenance_Type { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string Performed_By { get; set; }
        public string Status { get; set; }
        public string Next_Scheduled_Maintenance { get; set; }
    }
}
