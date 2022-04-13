using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FundTransferApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FundTransferController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<FundTransferController> _logger;

        public FundTransferController(ILogger<FundTransferController> logger)
        {
            _logger = logger;
        }
    }
}
