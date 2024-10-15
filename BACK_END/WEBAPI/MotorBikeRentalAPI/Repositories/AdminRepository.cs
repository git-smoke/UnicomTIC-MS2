using MotorBikeRentalAPI.IRepositories;

namespace MotorBikeRentalAPI.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly string connection_String = "Server=SMOKE-PC;Database=MotorBikeRentalManagement;Trusted_Connection=True;";
    }
}
