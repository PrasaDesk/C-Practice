using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_9_and_10
{
    class DiffEvenOddSum
    {
        public int iNo, iDiff;
        public AdditionEven ae;
        public AdditionOdd ao;
        public DiffEvenOddSum(int no)
        {
            if(no < 0)
            {
                no = -no;
            }
            iNo = no;
            ae = new AdditionEven(iNo);
            ao = new AdditionOdd(iNo);
        }

        public void DiffSum()
        {
            int ESum = 0, OSum = 0;
            ESum = ae.EvenSum();
            OSum = ao.OddSum();
            iDiff = ESum - OSum;
        }

        public void display()
        {
            Console.WriteLine("\n\nInsdie Diiference Class");
            if(iDiff < 0)
            {
                iDiff = -iDiff;
            }
            Console.WriteLine("Difference of Addition of Even Digits is : " + ae.EvenSum());
            Console.WriteLine("Difference of Addition of Odd Digits is : " + ao.OddSum());
            Console.WriteLine("Difference of Addition of Even And Odd Digits is : " + iDiff);
        }
    }
}
