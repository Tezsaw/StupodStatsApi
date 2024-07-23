using Microsoft.AspNetCore.Mvc;

namespace StupodStatsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JiffiesLivedController : ControllerBase
    {
        //                                               Nov 2nd 2011 (Added 5.5 hours cuz its slightly more accurate)
        private static readonly DateTime BirthDate = new DateTime(2011, 11, 2, 5, 30, 0); // prob add hour stuff soon
        
        private readonly ILogger<JiffiesLivedController> _logger;

        public JiffiesLivedController(ILogger<JiffiesLivedController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetJiffies")]
        public double Get()
        {
            return DateTime.Now.Subtract(BirthDate).TotalSeconds * 100;
        }
    }
}