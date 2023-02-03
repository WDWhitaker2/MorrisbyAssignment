using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morrisbyAssignment.Models
{
    public class Rectangle : Shape
    {
        public Rectangle(uint width, uint height)
        {
            Width = width;
            Height = height;
        }
        public uint Width { get; private  set; }
        public uint Height { get; private set; }

        public override string PrintToString()
        {
            return $"width={Width} height={Height}";
        }
    }
}
