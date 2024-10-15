namespace MotorBikeRentalAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Category_Name { get; set; }
        public string Description { get; set; }
        public decimal Base_Price { get; set; }
        public string License_Type_Required { get; set; }
    }
}
