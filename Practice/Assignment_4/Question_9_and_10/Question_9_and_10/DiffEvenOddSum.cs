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
            ae.EvenSum();
            ao.OddSum();
            iDiff = ae.iSum - ao.iSum;
        }

        public void display()
        {
            Console.WriteLine("\n\nInside Diiference Class");
            if(iDiff < 0)
            {
                iDiff = -iDiff;
            }
            Console.WriteLine("Difference of Addition of Even Digits is : " + ae.iSum);
            Console.WriteLine("Difference of Addition of Odd Digits is : " + ao.iSum);
            Console.WriteLine("Difference of Addition of Even And Odd Digits is : " + iDiff);
        }
    }
}
