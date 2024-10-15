using MotorBikeRentalAPI.IRepositories;

namespace MotorBikeRentalAPI.Repositories
{
    public class RentalRepository : IRentalRepository
    {
        private readonly string connection_String = "Server=SMOKE-PC;Database=MotorBikeRentalManagement;Trusted_Connection=True;";
    }
}
