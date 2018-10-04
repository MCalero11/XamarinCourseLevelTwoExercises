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
	public partial class ConferencesPage : ContentPage
	{
		public ConferencesPage()
		{
            
			InitializeComponent ();
            BindingContext = new ViewModels.ConferencesViewModel();
            
		}

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return;

            this.Navigation.PushAsync(new ConferenceDetailPage(e.Item));
        }
    }
}