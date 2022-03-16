using Microsoft.AspNetCore.Mvc;

namespace FirstService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirstController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "This is the first service";
        }
    }
}