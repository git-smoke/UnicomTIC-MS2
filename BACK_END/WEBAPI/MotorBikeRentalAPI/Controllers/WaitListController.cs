using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotorBikeRentalAPI.IServices;

namespace MotorBikeRentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaitListController : ControllerBase
    {
        private readonly IWaitListService _waitListService;

        public WaitListController(IWaitListService waitListService)
        {
            _waitListService = waitListService;
        }
    }
}
