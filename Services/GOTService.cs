using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using game_of_thrones_411_blazor.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace game_of_thrones_411_blazor.Service
{
    public class GOTService
    {
        private string _baseURL = "https://api.got.show/api/show/";
        public async Task<List<People>> GetPeopleAsync()
        {
            string url = $"{_baseURL}characters";

            HttpClient client = new HttpClient();
            return await client.GetJsonAsync<List<People>>(url);
        }

        public async Task<People> GetPersonAsync(string slug)
        {
            string url = $"{_baseURL}characters/bySlug/{slug}";

            HttpClient client = new HttpClient();
            return await client.GetJsonAsync<People>(url);
        }
    }
}
