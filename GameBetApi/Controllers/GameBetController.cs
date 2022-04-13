using GameBetApi.Models;
using Microsoft.AspNetCore.Mvc;
using RyGamingProviderClientLibrary;
using System;

namespace GameBetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameBetController : ControllerBase
    {
        [HttpPost("SingleBet")]
        public IActionResult SingleBet(BetModel betModel)
        {
            var gameBet = new GameBet(betModel.Token);

            try
            {
                var response = gameBet.SingleBet(betModel.Amount);

                if (response != null)
                {
                    return Ok(new { response });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return null;
        }
    }
}
