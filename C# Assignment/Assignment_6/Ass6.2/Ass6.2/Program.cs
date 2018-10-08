using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_6_Que_2
{
    class Program
    {
        static void Main(string[] args)
        {
             int start = 0;
            int end = 0;
            int ret = 0;
            Console.WriteLine("Enter the Start of Range");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end of Range");
            end = Convert.ToInt32(Console.ReadLine());
            MyRange ob = new MyRange(start, end);
            ob.DisplayEven();
            ob.DisplayOdd();
            ret=ob.SumRange();
            Console.WriteLine("\nSum of all Numbers is Range is : {0}", ret);
            ob.DisplayPrime();
            ob.DisplayPerfect();
        }
    }
}
