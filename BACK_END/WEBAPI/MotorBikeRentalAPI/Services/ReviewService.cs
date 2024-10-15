using MotorBikeRentalAPI.IRepositories;
using MotorBikeRentalAPI.IServices;

namespace MotorBikeRentalAPI.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
    }
}
