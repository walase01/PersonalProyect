using Prism;
using Prism.Unity;
using Prism.Ioc;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectAboutAnimal.Views;
using Prism.Navigation;
using ProyectAboutAnimal.ViewModels;
using ProyectAboutAnimal.Services;

namespace ProyectAboutAnimal
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer Initializar = null) : base (Initializar)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"{Const.Navigation}/{Const.MainPage}");

        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IfactDogsService, FactDogsService>();
            containerRegistry.RegisterForNavigation<NavigationPage>(Const.Navigation);
            containerRegistry.RegisterForNavigation<MainPage,MainViewModel>(Const.MainPage);
            
        }


    }

}

