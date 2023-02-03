using morrisbyAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace morrisbyAssignment.Models
{
    public class Drawing: IPrintable
    {
        public Drawing()
        {
            Widgets = new List<Widget>();
        }
        public List<Widget> Widgets { get; private set; }

        public void AddWidget(uint xAxis, uint yAxis , Shape shape)
        {
            Widgets.Add(new Widget { XAxis = xAxis, YAxis= yAxis, Shape = shape });
        }

        public string PrintToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("----------------------------------------------------------------");
            stringBuilder.AppendLine("Requested Drawing");
            stringBuilder.AppendLine("----------------------------------------------------------------");

            foreach (var widget in Widgets)
            {
                stringBuilder.AppendLine(widget.PrintToString());
            }
            stringBuilder.AppendLine("----------------------------------------------------------------");

            return stringBuilder.ToString();
        }
    }
}
