using Newtonsoft.Json;
using proyectAboutAnimal.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace proyectAboutAnimal.Services
{
    public class FactDogsService : IfactDogsService
    {
        public async Task<IEnumerable<FactDogs>> GetFactDogs()
        {
            IEnumerable<FactDogs> factDogs = null;
            HttpClient client = new HttpClient();

            var getfactDogs = await client.GetAsync(NavigationConstant.getallfect);

            if (getfactDogs.IsSuccessStatusCode)
            {
                var factDog = await getfactDogs.Content.ReadAsStringAsync();
                //factDogs = JsonConvert.DeserializeObject<IEnumerable<FactDogs>>(factDog);
                factDogs = JsonConvert.DeserializeObject<IEnumerable<FactDogs>>(factDog);
            }

            return factDogs;
        }
    }
}
