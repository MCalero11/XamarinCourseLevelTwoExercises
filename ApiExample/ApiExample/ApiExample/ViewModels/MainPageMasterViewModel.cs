using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiExample.ViewModels
{
	public class MainPageMasterViewModel : ViewModelBase
	{    
        public MainPageMasterViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
}
