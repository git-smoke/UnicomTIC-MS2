using MotorBikeRentalAPI.IRepositories;

namespace MotorBikeRentalAPI.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string connection_String = "Server=SMOKE-PC;Database=MotorBikeRentalManagement;Trusted_Connection=True;";
    }
}
