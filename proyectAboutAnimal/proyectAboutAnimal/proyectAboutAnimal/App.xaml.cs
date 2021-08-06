using Prism;
using Prism.Ioc;
using Prism.Unity;
using proyectAboutAnimal.Services;
using proyectAboutAnimal.ViewModels;
using proyectAboutAnimal.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyectAboutAnimal
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer Initializer): base(Initializer)
        {
        }

        protected async override void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"{Config.navigation}/{Config.main}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IfactDogsService, FactDogsService>();

            containerRegistry.RegisterForNavigation<NavigationPage>(Config.navigation);
            containerRegistry.RegisterForNavigation<MainPage, MainViewModel>(Config.main);
        }

        //protected override async void OnStart()
        //{
        //    base.OnStart();

        //    var service = new FactDogsService();

        //    var facts = await service.GetFactDogs();
        //}
    }
}
