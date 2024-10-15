using MotorBikeRentalAPI.IRepositories;

namespace MotorBikeRentalAPI.Repositories
{
    public class WaitListRepository : IWaitListRepository
    {
        private readonly string _connectionString;

        public WaitListRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
