using MotorBikeRentalAPI.IRepositories;

namespace MotorBikeRentalAPI.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly string _connectionString;

        public AdminRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

    }
}
