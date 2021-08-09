using proyectAboutAnimal.Models;
using proyectAboutAnimal.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace proyectAboutAnimal.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public string Nombre { get; set; } = "Jose Ramon";

        public ObservableCollection<FactDogs> Facts { get; set; } 

        public MainViewModel(IfactDogsService ifactDogs) : base(ifactDogs)
        {          
            LoadFact();
        }

        async Task LoadFact()
        {

            var factInformation = await dogsService.GetFactDogs();

            if (factInformation != null)
            {

                Facts = new ObservableCollection<FactDogs>(factInformation);

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "No tiene Acceso a internet", "cancel");
            }


        }
    }
}