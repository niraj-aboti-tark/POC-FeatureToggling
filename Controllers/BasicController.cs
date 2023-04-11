using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace FeatureToggeling.Controllers
{

    [FeatureGate("FeatureB")]
    [Route("api/[controller]"), AllowAnonymous]
    public class BasicController : Controller
    {
        [Route(""), HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Status = "OK" });
        }
      
    }
}
