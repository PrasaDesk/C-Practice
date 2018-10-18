using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int iStart = 0, iEnd=0;
            Console.WriteLine("Enter Start Number : ");
            iStart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Start Number : ");
            iEnd = Convert.ToInt32(Console.ReadLine());
            Range rg = new Range(iStart, iEnd);
            rg.displayRange();
        }
    }
}
