using MotorBikeRentalAPI.IRepositories;

namespace MotorBikeRentalAPI.Repositories
{
    public class WaitListRepository : IWaitListRepository
    {
        private readonly string connection_String = "Server=SMOKE-PC;Database=MotorBikeRentalManagement;Trusted_Connection=True;";
    }
}
