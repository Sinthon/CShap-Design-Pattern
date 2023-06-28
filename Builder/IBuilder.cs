using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Pattern.Builder
{
    public interface IBuilder
    {
        void SetAttribute1(string attribute1);
        void SetAttribute2(string attribute2);
        // ...
        Product GetProduct();
    }
}
