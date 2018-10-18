using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int iStart = 0, iEnd = 0;
            Console.WriteLine("Enter Start Number : ");
            iStart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter End Number : ");
            iEnd = Convert.ToInt32(Console.ReadLine());

            EvenRange er = new EvenRange(iStart,iEnd);
            er.DisplayEven();

        }
    }
}
