//Accept two Numbrers andprint its largest common factor.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo1 = 0, iNo2 = 0;

            Console.Write("Enter two number : ");
            iNo1 = Convert.ToInt32(Console.ReadLine());
            iNo2 = Convert.ToInt32(Console.ReadLine());

            LargestFactor lf = new LargestFactor(iNo1,iNo2);
            lf.Factor();
            lf.Display();

        }
    }
}
