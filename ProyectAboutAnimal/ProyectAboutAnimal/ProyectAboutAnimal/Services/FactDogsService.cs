using Newtonsoft.Json;
using ProyectAboutAnimal.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProyectAboutAnimal.Services
{
    class FactDogsService : IfactDogsService
    {
        public async Task<FactDogs> GetFactDogs()
        {
            FactDogs factDogs = null;
            HttpClient client = new HttpClient();

            var getfactDogs = await client.GetAsync(Const.urlfactFogs);

            if (getfactDogs.IsSuccessStatusCode)
            {
                var factDog = await getfactDogs.Content.ReadAsStringAsync();
                factDogs = JsonConvert.DeserializeObject<FactDogs>(factDog);
            }

            return factDogs;
            
        }
    }
}
