using ProyectAboutAnimal.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectAboutAnimal.Services
{
    public interface IfactDogsService
    {
        Task<FactDogs> GetFactDogs();
    }
}
