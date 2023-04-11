using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace FeatureToggeling.Controllers
{
    [FeatureGate("FeatureC")]
    [Route("api/[controller]"), AllowAnonymous]
    public class InfoController : Controller
    {
        [Route(""), HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Status = "OK" });
        }
        
    }
}
