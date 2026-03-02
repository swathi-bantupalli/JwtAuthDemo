using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("This is protected data. Only logged-in users can see this.");
        }
    }
}
