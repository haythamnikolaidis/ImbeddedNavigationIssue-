using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Unity;
using ImbeddedNavigationIssue.Views;
using Xamarin.Forms;
using ImbeddedNavigationIssue.ViewModels;

namespace ImbeddedNavigationIssue
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("/NavigationPage/MainTabbedPage/FirstPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();

            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainTabbedPage>();

            Container.RegisterTypeForNavigation<DetailsPage>();

            Container.RegisterTypeForNavigation<FirstPage, MainPageViewModel>();
            Container.RegisterTypeForNavigation<SecondPage, MainPageViewModel>();
            Container.RegisterTypeForNavigation<ThirdPage, MainPageViewModel>();
            Container.RegisterTypeForNavigation<FourthPage, MainPageViewModel>();
            Container.RegisterTypeForNavigation<FithPage, MainPageViewModel>();
            Container.RegisterTypeForNavigation<SixthPage, MainPageViewModel>();
            Container.RegisterTypeForNavigation<SeventhPage, MainPageViewModel>();
        }
    }
}

