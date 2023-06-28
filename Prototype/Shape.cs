using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Pattern.Prototype
{
    public abstract class Shape : ICloneable
    {
        public string Type { get; set; }

        public abstract void Draw();

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
