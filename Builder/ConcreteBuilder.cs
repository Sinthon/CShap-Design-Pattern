using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Pattern.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void SetAttribute1(string attribute1)
        {
            _product.Attribute1 = attribute1;
        }

        public void SetAttribute2(string attribute2)
        {
            _product.Attribute2 = attribute2;
        }

        // ...

        public Product GetProduct()
        {
            return _product;
        }
    }
}
