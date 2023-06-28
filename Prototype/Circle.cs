using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Pattern.Prototype
{
    public class Circle : Shape
    {
        public Circle()
        {
            Type = "Circle";
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}
