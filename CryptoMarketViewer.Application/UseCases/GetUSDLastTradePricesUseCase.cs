using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CryptoMarketViewer.Application.Interfaces;
using CryptoMarketViewer.Domain.Entities;

namespace CryptoMarketViewer.Application.UseCases
{
    public class GetUSDLastTradePricesUseCase
    {
        private readonly ICryptoApiService _cryptoApiService;

        public GetUSDLastTradePricesUseCase(ICryptoApiService cryptoApiService)
        {
            _cryptoApiService = cryptoApiService;
        }

        public async Task<IEnumerable<Cryptocurrency>> ExecuteAsync()
        {
            var cryptocurrencies = await _cryptoApiService.GetCryptocurrenciesAsync();
            return cryptocurrencies
                .Where(crypto => crypto.Symbol.EndsWith("-USD"))
                .ToList();
        }
    }
}
