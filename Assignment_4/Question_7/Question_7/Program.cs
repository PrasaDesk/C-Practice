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
            int iNo = 0;
            Console.Write("Enter the Numbber : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            GreaterCount gc = new GreaterCount(iNo);
            gc.CountGreater5();
            gc.display();

        }
    }
}
