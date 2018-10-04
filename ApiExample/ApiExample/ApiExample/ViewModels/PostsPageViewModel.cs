using ApiExample.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.ViewModels
{
	public class PostsPageViewModel : ViewModelBase
	{
        public int UserId { get; set; }

        public ObservableCollection<Post> Posts { get; set; }

        public PostsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            
        }

        
        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            int id;
            if(int.TryParse(parameters["id"].ToString(),out id))
            {
                UserId = id;
            }
            else
            {
                UserId = -1;
            }

            base.OnNavigatingTo(parameters);

            CargarPosts();
        }

        private async void CargarPosts()
        {
            if (UserId == -1)
            {
                Title = "All Post";
                await Task.Delay(5000);
                // Cargar todos los posts
            }
            else
            {
                await Task.Delay(5000);
                // Cargar post by userId
                Title = "Name User";
            }
        }

    }
}
