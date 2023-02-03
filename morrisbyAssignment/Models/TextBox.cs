using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morrisbyAssignment.Models
{
    public class TextBox : Shape
    {
        public TextBox(uint width, uint height, string text)
        {
            Width = width;
            Height = height;
            Text = text;

        }
        public uint Width { get; private set; }
        public uint Height { get; private set; }
        public string Text { get; private set; }

        public override string PrintToString()
        {
            return $"width={Width} height={Height} Text=\"{Text}\"";
        }
    }
}
