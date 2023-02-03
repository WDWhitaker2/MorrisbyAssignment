using morrisbyAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morrisbyAssignment.Models
{
    public abstract class Shape : IPrintable
    {
        public abstract string PrintToString();
    }
}
