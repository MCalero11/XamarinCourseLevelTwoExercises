using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConferenceMVVM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConferenceDetailPage : ContentPage
	{
		public ConferenceDetailPage ()
		{
			InitializeComponent ();
		}
        public ConferenceDetailPage(object e)
        {
            BindingContext = new ViewModels.ConferenceDetailViewModel(e);
            InitializeComponent();
        }
    }
}