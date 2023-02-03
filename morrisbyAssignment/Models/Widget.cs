using morrisbyAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morrisbyAssignment.Models
{
    public class Widget: IPrintable
    {
        public uint XAxis { get; set; }
        public uint YAxis { get; set; }
        public Shape Shape { get; set; }

        public string PrintToString()
        {
            Type t = Shape.GetType();

            return $"{t.Name} ({XAxis},{YAxis}) {Shape.PrintToString()}";
        }
    }
}
