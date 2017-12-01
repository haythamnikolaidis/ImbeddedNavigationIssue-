using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ImbeddedNavigationIssue.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {

        private INavigationService navigationService;

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string navigatedToText;
        public string NavigatedToText
        {
            get { return navigatedToText; }
            set { SetProperty(ref navigatedToText, value); }
        }

        private string navigatingToText;
        public string NavigatingToText
        {
            get { return navigatingToText; }
            set { SetProperty(ref navigatingToText, value); }
        }

        private DelegateCommand navigateToDetails;
        public DelegateCommand NavigateCommand
        {
            get { return navigateToDetails; }
            set { SetProperty(ref navigateToDetails, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
        {

            this.navigationService = navigationService;
            NavigateCommand = new DelegateCommand(NavigateToDetailsPage);

            NavigatedToText = "Navigated To NOT Fired";
            NavigatingToText = "Navigating To NOT Fired";


        }

        private async void NavigateToDetailsPage(){

            await navigationService.NavigateAsync("DetailsPage", null, false);

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            NavigatedToText = "Navigated To Fired";
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            NavigatingToText = "Navigating To Fired";
        }
    }
}

