﻿using FundTransferApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RyGamingProviderClientLibrary;

namespace FundTransferApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FundTransferController : ControllerBase
    {
        private readonly ILogger<FundTransferController> _logger;

        public FundTransferController(ILogger<FundTransferController> logger)
        {
            _logger = logger;
        }

        [HttpPost("TopUp")]
        public IActionResult TopUp(TopUpModel topUpModel)
        {
            var fundTransfer = new FundTransfer(topUpModel.Token);
            var response = fundTransfer.TopUp(topUpModel.Amount);

            if (response != null)
            {
                return Ok(new { response });
            }

            return null;
        }

        [HttpPost("Withdraw")]
        public IActionResult Withdraw(WithdrawModel withdraw)
        {
            var fundTransfer = new FundTransfer(withdraw.Token);
            var response = fundTransfer.Withdraw(withdraw.Amount);

            if (response != null)
            {
                return Ok(new { response });
            }

            return null;
        }
    }
}
