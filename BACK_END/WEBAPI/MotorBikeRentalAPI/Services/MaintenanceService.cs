using MotorBikeRentalAPI.IRepositories;

namespace MotorBikeRentalAPI.Services
{
    public class MaintenanceService
    {
        private readonly IMaintenanceRepository _maintenanceRepository;

        public MaintenanceService(IMaintenanceRepository maintenanceRepository)
        {
            _maintenanceRepository = maintenanceRepository;
        }
    }
}
