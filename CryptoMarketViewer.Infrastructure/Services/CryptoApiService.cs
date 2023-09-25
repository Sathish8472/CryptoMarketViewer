using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CryptoMarketViewer.Application.Interfaces;
using CryptoMarketViewer.Domain.Entities;
using Newtonsoft.Json;

namespace CryptoMarketViewer.Infrastructure.Services
{
    public class CryptoApiService : ICryptoApiService
    {
        private readonly HttpClient _httpClient;

        public CryptoApiService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IEnumerable<Cryptocurrency>> GetCryptocurrenciesAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("https://api.blockchain.com/v3/exchange/tickers");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var cryptocurrencies = JsonConvert.DeserializeObject<List<Cryptocurrency>>(responseBody);

                return cryptocurrencies;
            }
            catch (Exception ex)
            {
                // Handle exceptions (logging, rethrow, etc.)
                throw ex;
            }
        }
    }
}
