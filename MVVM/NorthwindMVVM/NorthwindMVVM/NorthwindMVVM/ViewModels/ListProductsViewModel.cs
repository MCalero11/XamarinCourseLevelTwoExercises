using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using NorthwindMVVM.Models;
using Xamarin.Forms;

namespace NorthwindMVVM.ViewModels
{
    public class ListProductsViewModel
    {
        public ListProductsViewModel() {
            var VM = new AddProductViewModel

            {

                NewItemAdded = (sender, item) => Products.Add(item)

            };
            New = new Command

                (

                async () =>

                {

                    await GetCurrentNavigation().PushModalAsync(new Views.AddProductPage { BindingContext = VM });

                }

                );
        }
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();

        public Command New { get; set; }

        private INavigation GetCurrentNavigation()
        {
            return (Application.Current as App).MainPage.Navigation;
        }

    }
}
