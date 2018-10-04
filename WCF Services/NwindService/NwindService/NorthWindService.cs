using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NwindService
{
    public class NorthWindService : INorthWindService
    {
        public Product GetProductById(int id)
        {
            Product response = null;
            response = MockProducts.GetProducts().Where(p => p.Id == id).FirstOrDefault();

            return response;
        }

        public List<Product> GetProducts()
        {
            return MockProducts.GetProducts();
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            List<Product> response = null;
            response = MockProducts.GetProducts().Where(p => p.CategoryId == categoryId).ToList();
            return response;
        }
    }
}
