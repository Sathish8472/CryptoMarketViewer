using CryptoMarketViewer.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace CryptoMarketViewer.API.Controllers
{
    [ApiController]
    [Route("api/cryptocurrencies")]
    public class CryptoController : ControllerBase
    {
        private readonly GetUSDLastTradePricesUseCase _getUSDLastTradePricesUseCase;

        public CryptoController(GetUSDLastTradePricesUseCase getUSDLastTradePricesUseCase)
        {
            _getUSDLastTradePricesUseCase = getUSDLastTradePricesUseCase;
        }

        [HttpGet("usd")]
        public async Task<IActionResult> GetUSDLastTradePrices()
        {
            var cryptocurrencies = await _getUSDLastTradePricesUseCase.ExecuteAsync();
            return Ok(cryptocurrencies);
        }
    }
}
