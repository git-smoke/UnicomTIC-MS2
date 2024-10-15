using MotorBikeRentalAPI.IRepositories;

namespace MotorBikeRentalAPI.Repositories
{
    public class RentalRepository : IRentalRepository
    {
        private readonly string _connectionString;

        public RentalRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
