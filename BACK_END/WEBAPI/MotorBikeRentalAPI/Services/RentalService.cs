using MotorBikeRentalAPI.IRepositories;
using MotorBikeRentalAPI.IServices;

namespace MotorBikeRentalAPI.Services
{
    public class RentalService : IRentalService
    {
        private readonly IRentalRepository _rentalRepository;
        public RentalService(IRentalRepository rentalRepository)
        {
            _rentalRepository = rentalRepository;
        }
    }
}
