using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Pattern.Builder
{
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.SetAttribute1("Value1");
            _builder.SetAttribute2("Value2");
            // ...
        }
    }
}
