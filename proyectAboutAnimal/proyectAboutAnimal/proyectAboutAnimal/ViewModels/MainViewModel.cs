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
    public class MainViewModel : INotifyPropertyChanged
    {
        public string Nombre { get; set; } = "Jose Ramon";

        public ObservableCollection<FactDogs> Facts { get; set; }

        private IfactDogsService ifactDogs;

        public event PropertyChangedEventHandler PropertyChanged;

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
                Facts = new ObservableCollection<FactDogs>(factInformation);

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "No tiene Acceso a internet", "cancel");
            }


        }
    }
}