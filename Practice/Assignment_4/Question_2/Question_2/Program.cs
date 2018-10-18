using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo = 0;
            Console.Write("Emter the Number : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            AdditionDigit ad = new AdditionDigit(iNo);
            ad.Addition();
            ad.display();

        }
    }
}
