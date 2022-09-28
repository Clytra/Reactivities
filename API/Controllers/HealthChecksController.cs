using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/hc")]
    public class HealthChecksController : BaseApiController
    {
        // TODO implement HealthCheck controller
        [HttpGet]
        public async Task<ActionResult<string>> GetAsync()
        {
            return "Healthy";
        }
    }
}
