using proyectAboutAnimal.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace proyectAboutAnimal.Services
{
    public interface IfactDogsService
    {
        Task<FactDogs> GetFactDogs();
    }
}
