using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controller
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var Username = User.Identity.Name;
            return Ok($"Hello {Username},this is protected data.");
        }
    }
}
