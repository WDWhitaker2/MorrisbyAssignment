using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morrisbyAssignment.Models
{
    public class Circle : Shape
    {
        public Circle(uint diameter)
        {
            Diameter = diameter;
        }
        public uint Diameter { get; private set; }


        public override string PrintToString()
        {
            return $"size={Diameter}";
        }
    }
}
