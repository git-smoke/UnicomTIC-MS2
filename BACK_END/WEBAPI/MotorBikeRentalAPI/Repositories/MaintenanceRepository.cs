using MotorBikeRentalAPI.IRepositories;

namespace MotorBikeRentalAPI.Repositories
{
    public class MaintenanceRepository : IMaintenanceRepository
    {
        private readonly string _connectionString;

        public MaintenanceRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
