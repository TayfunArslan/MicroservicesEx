using Microsoft.AspNetCore.Mvc;

namespace SecondService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecondController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "This is the second service";
        }
    }
}