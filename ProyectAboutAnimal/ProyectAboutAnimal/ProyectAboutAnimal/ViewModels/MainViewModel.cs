using ProyectAboutAnimal.Models;
using ProyectAboutAnimal.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace ProyectAboutAnimal.ViewModels
{
    public class MainViewModel
    {
        public string Nombre { get; set; } = "Jose Ramon";

        public ObservableCollection<string> facts { get; } = new ObservableCollection<string>();
        //public FactDogs datos { get; set; }

        //public char factInformationI { get; set; }

        private IfactDogsService ifactDogs;

        public MainViewModel(IfactDogsService dogsService)
        {
            this.ifactDogs = dogsService;
            LoadFact();
        }

        async Task LoadFact()
        {
            var factInformation = await ifactDogs.GetFactDogs();
            if(factInformation != null)
            {
                var datos = factInformation.Fact;
                foreach (var c in datos)
                {
                    facts.Add(c.ToString());
                }

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "No tiene Acceso a internet", "cancel");
            }
            
        }

    }
}
