using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Pattern.Factory
{
    public class ConcreteProductA : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("Doing something in ConcreteProductA");
        }
    }
}
