using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NwindService
{
    [DataContract]
    public class Product
    {
        [DataMember]
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember]
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        private int _categoryId;

        public int CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; }
        }


    }
}
