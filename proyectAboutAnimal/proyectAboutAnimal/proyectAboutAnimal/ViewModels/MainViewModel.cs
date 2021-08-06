using proyectAboutAnimal.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace proyectAboutAnimal.ViewModels
{
    public class MainViewModel
    {
        public string Nombre { get; set; } = "Jose Ramon";

        public ObservableCollection<char> facts { get; } = new ObservableCollection<char>();

        private IfactDogsService ifactDogs;

        public MainViewModel(IfactDogsService dogsService)
        {
            this.ifactDogs = dogsService;
            LoadFact();
        }

        async Task LoadFact()
        {
            var factInformation = await ifactDogs.GetFactDogs();
            if (factInformation != null)
            {
                //var datos = factInformation.Fact;
                foreach (var c in factInformation.Fact)
                {
                    facts.Add(c);
                }

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "No tiene Acceso a internet", "cancel");
            }


        }
    }
}