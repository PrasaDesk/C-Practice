using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo = 0;
            int iRet = 0;

            Console.Write("Enter the Number to Find Fctorial : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            Factorial factorial = new Factorial(iNo);
            factorial.fact();
            factorial.display();
        }
    }
}
