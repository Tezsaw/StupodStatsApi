using Microsoft.AspNetCore.Mvc;

namespace StupodStatsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JiffiesLivedController : ControllerBase
    {
        //                                               Nov 2nd 2011
        private static readonly DateTime BirthDate = new DateTime(2011, 11, 2); // prob add hour stuff soon
        
        private readonly ILogger<JiffiesLivedController> _logger;

        public JiffiesLivedController(ILogger<JiffiesLivedController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetJiffies")]
        public long Get()
        {
            long x = 1;
            return x;
        }
    }
}