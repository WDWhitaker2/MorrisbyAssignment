using morrisbyAssignment.Models;
using System;
using System.Text;

namespace morrisbyAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var Drawing1 = new Drawing();
            Drawing1.AddWidget(10, 10, new Rectangle(30, 40));
            Drawing1.AddWidget(15, 30, new Square(35));
            Drawing1.AddWidget(100, 150, new Ellipse(300, 200));
            Drawing1.AddWidget(1, 1, new Circle(300));
            Drawing1.AddWidget(5, 5, new TextBox(200, 100, "sample text"));


            Console.WriteLine(Drawing1.PrintToString());
            Console.ReadLine();
        }


        


    }
}
