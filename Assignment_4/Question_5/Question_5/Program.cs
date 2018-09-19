using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo = 0;
            Console.Write("Enter the NUmber : ");
            iNo = Convert.ToInt32(Console.ReadLine());


            Reverse r = new Reverse(iNo);
            r.ReversePrint();
            r.display();
        }
    }
}
