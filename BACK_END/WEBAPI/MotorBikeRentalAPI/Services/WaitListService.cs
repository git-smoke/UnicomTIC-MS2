using MotorBikeRentalAPI.IRepositories;
using MotorBikeRentalAPI.IServices;

namespace MotorBikeRentalAPI.Services
{
    public class WaitListService : IWaitListService
    {
        private readonly IWaitListRepository _waitListRepository;
        public WaitListService(IWaitListRepository waitListRepository)
        {
            _waitListRepository = waitListRepository;
        }
    }
}
