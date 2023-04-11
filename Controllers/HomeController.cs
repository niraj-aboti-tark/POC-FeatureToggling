using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;

namespace FeatureToggeling.Controllers
{

    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IFeatureDefinitionProvider _featureDefinitionProvider;
        public HomeController(IFeatureDefinitionProvider featureDefinitionProvider)
        {
            _featureDefinitionProvider = featureDefinitionProvider;
        }

        [FeatureGate("FeatureA")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(new { Status = "OK" });
        }

        [Route("features"), HttpGet]
        public IActionResult GetFeatures()
        {
            var features = _featureDefinitionProvider.GetAllFeatureDefinitionsAsync();
            return Ok(features);
        }
    }
}
