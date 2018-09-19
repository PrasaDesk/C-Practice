using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionn_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo1 =0,iNo2= 0, iNo3= 0;
            Console.Write("Enter Three Number: ");
            iNo1 = Convert.ToInt32(Console.ReadLine());
            iNo2 = Convert.ToInt32(Console.ReadLine());
            iNo3 = Convert.ToInt32(Console.ReadLine());

            Average av = new Average(iNo1,iNo2,iNo3);
            av.Avg();
            av.display();

        }
    }
}
