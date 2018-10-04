using NorthwindMVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NorthwindMVVM.ViewModels
{
    public class AddProductViewModel
    {
        public EventHandler<Product> NewItemAdded;

        public Command Guardar { get; set; }
        public Command Cancelar { get; set; }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Existecia { get; set; }

        Random random = new Random();
        public AddProductViewModel()
        {
            Guardar = new Command(
                     () =>
                    {
                        
                        NewItemAdded(this, new Product {
                            Id = random.Next(1, 1000),
                            Nombre = Nombre,
                            Precio = Precio,
                            Existecia = Existecia,
                        });
                        Id = 0;
                        Precio = 0;
                        Nombre = "";
                        Existecia = 0;
                        (Application.Current as App).MainPage.Navigation.PopModalAsync();
                    }
                );

            Cancelar = new Command(() => (Application.Current as App).MainPage.Navigation.PopModalAsync());
        }
    }
}
