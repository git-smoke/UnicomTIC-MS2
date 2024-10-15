using MotorBikeRentalAPI.IRepositories;
using MotorBikeRentalAPI.IServices;

namespace MotorBikeRentalAPI.Services
{
    public class MotorBikeService : IMotorBikeService
    {
        private readonly IMotorBikeRepository _motorBikeRepository;
        public MotorBikeService(IMotorBikeRepository motorBikeRepository)
        {
            _motorBikeRepository = motorBikeRepository;
        }
    }
}
