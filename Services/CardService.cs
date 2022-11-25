using System;
using System.Net.Http.Json;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using TestMudBlazorApplication.Models;

namespace TestMudBlazorApplication.Services
{
    public interface ICardService
    {
        Task<List<Card>> GetAllCards();
    }
    public class CardService : ICardService
    {
        private HttpClient _http;
        CardService(HttpClient Http) {
            _http = Http;

        }

        public async Task<List<Card>> GetAllCards()
        {
            return await _http.GetFromJsonAsync<List<Card>>("http://localhost:5213/api/Card/Cards");
        }
    }
}
