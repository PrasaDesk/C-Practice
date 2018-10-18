using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    class Circum
    {
        public double Radius, Cir;

        public void accept()
        {
            Console.Write("Enter Radius of Circile : ");
            Radius = Convert.ToDouble(Console.ReadLine());
        }

        public void cirumference()
        {
            Cir = 2 * 3.14 * Radius;
        }

        public void display()
        {
            Console.WriteLine("Circumference of circle is " + Cir);
        }
    }
}
