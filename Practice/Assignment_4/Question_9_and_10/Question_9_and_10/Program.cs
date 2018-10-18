using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_9_and_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo;
            Console.Write("Enter the Number : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            AdditionOdd AOdd = new AdditionOdd(iNo);
            AdditionEven AEven = new AdditionEven(iNo);

            AOdd.OddSum();
            AOdd.display();

            AEven.EvenSum();
            AEven.display();

            DiffEvenOddSum deos = new DiffEvenOddSum(iNo);
            deos.DiffSum();
            deos.display();

        }
    }
}
