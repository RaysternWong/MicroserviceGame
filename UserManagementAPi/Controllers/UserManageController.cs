using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RyGamingProviderClientLibrary;
using UserManagementAPi.Models;

namespace UserManagementAPi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserManageController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UserManageController> _logger;

        public UserManageController(ILogger<UserManageController> logger)
        {
            _logger = logger;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginModel loginModel)
        {
            var auth = new Authentication();
            var response = auth.Login(loginModel.Name, loginModel.Password);

            if (response != null)
            {
                return Ok(new { response });
            }

            return null;
        }
    }
}
