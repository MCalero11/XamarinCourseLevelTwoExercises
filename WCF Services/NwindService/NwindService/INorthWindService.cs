using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NwindService
{
    [ServiceContract]
    public interface INorthWindService
    {
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        List<Product> GetProductsByCategoryId(int categoryId);

        [OperationContract]
        Product GetProductById(int id);
        
    }
}
