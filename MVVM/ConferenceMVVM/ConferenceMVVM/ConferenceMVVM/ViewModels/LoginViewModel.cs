using ConferenceMVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
namespace ConferenceMVVM.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        public Command LoginCommand { get; set; }
        public User user { get; set; } = new User();

        public LoginViewModel()
        {
            Title = "Login";
            LoginCommand = new Command( async()=>{
                IsBusy = true;
                if(await Credentials())
                {

                    App.Current.MainPage = new NavigationPage(new Views.ConferencesPage());
                    //await App.Current.MainPage.Navigation.PushAsync(new Views.ConferencesPage());
                    
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Credenciales no válidas", "Okay");
                }
                IsBusy = false;
            });
        }

        private async Task<bool> Credentials()
        {
            await Task.Delay(1000);
            return (user.Name == "admin" && user.Password == "admin") ? true : false;
        }
    }
}
