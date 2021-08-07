using proyectAboutAnimal.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace proyectAboutAnimal.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {

        protected IfactDogsService dogsService;

        public BaseViewModel(IfactDogsService ifactDogs)
        {
            this.dogsService = ifactDogs;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
