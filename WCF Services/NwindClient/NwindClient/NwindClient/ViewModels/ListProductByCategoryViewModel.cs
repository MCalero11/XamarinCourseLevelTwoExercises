using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NwindClient.ViewModels
{
	public class ListProductByCategoryViewModel : ViewModelBase
	{
        public ListProductByCategoryViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
