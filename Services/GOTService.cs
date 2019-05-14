using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using game_of_thrones_411_blazor.Models;
using Microsoft.AspNetCore.Components;

namespace game_of_thrones_411_blazor.Service
{
    public class GOTService
    {
        public async Task<People[]> GetPeopleAsync()
        {
            HttpClient client = new HttpClient();
            return await client.GetJsonAsync<People[]>("https://api.got.show/api/show/characters");
        }
    }
}
