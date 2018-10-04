using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwindService
{
    public class MockProducts
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>() {
                new Product() {
                    Id          = 1,
                    Name        = "Crema",
                    CategoryId  = 1,
                },
                new Product() {
                    Id          = 2,
                    Name        = "queso",
                    CategoryId  = 1,
                },
                new Product() {
                    Id          = 3,
                    Name        = "cuajada",
                    CategoryId  = 1,
                },
                new Product() {
                    Id          = 4,
                    Name        = "aceite",
                    CategoryId  = 2,
                },
                new Product() {
                    Id          = 5,
                    Name        = "pasta",
                    CategoryId  = 2,
                },
                new Product() {
                    Id          = 6,
                    Name        = "tijeras",
                    CategoryId  = 3,
                },
                new Product() {
                    Id          = 7,
                    Name        = "lápiz de color",
                    CategoryId  = 3,
                },
                new Product() {
                    Id          = 8,
                    Name        = "borrador",
                    CategoryId  = 3,
                },
                new Product() {
                    Id          = 9,
                    Name        = "lapicero",
                    CategoryId  = 3,
                },
                new Product() {
                    Id          = 10,
                    Name        = "llantas",
                    CategoryId  = 4,
                },
                new Product() {
                    Id          = 11,
                    Name        = "limpiador",
                    CategoryId  = 4,
                },
                new Product() {
                    Id          = 12,
                    Name        = "cera",
                    CategoryId  = 4,
                },
                new Product() {
                    Id          = 13,
                    Name        = "rines",
                    CategoryId  = 4,
                },

            };
        }
    }
}
