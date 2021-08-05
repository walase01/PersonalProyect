using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text;

namespace ProyectAboutAnimal.Models
{
    public class FactDogs
    {
        [JsonPropertyName("fact")]
        public string Fact { get; set; }
        //public IDictionary<string,string> Fact { get; set; }
    }
}
