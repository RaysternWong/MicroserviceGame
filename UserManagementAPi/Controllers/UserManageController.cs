using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RyGamingProviderClientLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
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
