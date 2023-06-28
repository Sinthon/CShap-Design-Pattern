using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Pattern.Factory
{
    public class Client
    {
        private readonly ProductFactory _productFactory;

        public Client(ProductFactory productFactory)
        {
            _productFactory = productFactory;
        }

        public void DoSomethingWithProduct(string productType)
        {
            IProduct product = _productFactory.CreateProduct(productType);
            product.DoSomething();
        }
    }

}
