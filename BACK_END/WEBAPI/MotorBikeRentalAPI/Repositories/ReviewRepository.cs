using MotorBikeRentalAPI.IRepositories;

namespace MotorBikeRentalAPI.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly string _connectionString;

        public ReviewRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
