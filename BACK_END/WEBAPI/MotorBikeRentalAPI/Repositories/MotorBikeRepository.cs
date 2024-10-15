using MotorBikeRentalAPI.IRepositories;

namespace MotorBikeRentalAPI.Repositories
{
    public class MotorBikeRepository : IMotorBikeRepository
    {
        private readonly string _connectionString;

        public MotorBikeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
