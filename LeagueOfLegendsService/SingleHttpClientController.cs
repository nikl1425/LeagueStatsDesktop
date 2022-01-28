using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsService
{
    public class SingleHttpClientController
    {

        private static readonly HttpClient _httpClient;
        private static readonly string _apiKey = "RGAPI-4b6cf148-2072-40b7-aec0-96a523231896";

        static SingleHttpClientController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://euw1.api.riotgames.com/lol/");
            _httpClient.DefaultRequestHeaders.Add("api_key", _apiKey);
        }

        public HttpClient GetClient()
        {
            return _httpClient;
        }


    }
}
