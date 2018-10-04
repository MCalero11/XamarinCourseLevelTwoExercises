using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindMVVM.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Existecia { get; set; }
    }
}
