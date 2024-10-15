using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotorBikeRentalAPI.IServices;

namespace MotorBikeRentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorBikeController : ControllerBase
    {
        private readonly IMotorBikeService _motorBikeService;
        public MotorBikeController(IMotorBikeService motorBikeService)
        {
            _motorBikeService = motorBikeService;
        }
    }
}
