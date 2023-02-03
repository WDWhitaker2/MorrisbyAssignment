using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morrisbyAssignment.Models
{
    public class Ellipse : Shape
    {
        public Ellipse(uint horizontalDiameter, uint verticalDiameter)
        {
            VerticalDiameter = verticalDiameter;
            HorizontalDiameter = horizontalDiameter;
        }
        public uint VerticalDiameter { get; private set; }
        public uint HorizontalDiameter { get; private set; }
        public override string PrintToString()
        {
            return $"diameterH={HorizontalDiameter} diameterV={VerticalDiameter}";
        }
    }
}
