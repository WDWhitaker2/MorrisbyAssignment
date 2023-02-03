using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morrisbyAssignment.Models
{
    public class Square : Shape
    {
        public Square(uint size)
        {
            Width = size;
        }

        public uint Width { get; private set; }

        
        public override string PrintToString()
        {
            return $"size={Width}";
        }
    }
}
