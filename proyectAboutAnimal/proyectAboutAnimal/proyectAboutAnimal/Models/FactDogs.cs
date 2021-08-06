using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace proyectAboutAnimal.Models
{
    public class FactDogs
    {
        [JsonPropertyName("fact")]
        public string Fact { get; set; }
    }
}
