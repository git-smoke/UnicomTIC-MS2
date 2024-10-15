using MotorBikeRentalAPI.IRepositories;
using MotorBikeRentalAPI.IServices;

namespace MotorBikeRentalAPI.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
    }
}
