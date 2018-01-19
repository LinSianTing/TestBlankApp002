using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankApp1.ViewModels
{
    public class MainPage02ViewModel : ViewModelBase
    {
        public MainPage02ViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page 02";
        }
    }
}
