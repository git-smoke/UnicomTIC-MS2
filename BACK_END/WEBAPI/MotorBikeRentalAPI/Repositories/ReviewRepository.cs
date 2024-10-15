using MotorBikeRentalAPI.IRepositories;

namespace MotorBikeRentalAPI.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly string connection_String = "Server=SMOKE-PC;Database=MotorBikeRentalManagement;Trusted_Connection=True;";
    }
}
