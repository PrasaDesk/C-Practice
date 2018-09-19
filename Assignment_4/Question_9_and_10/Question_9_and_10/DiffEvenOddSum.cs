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
       
        public DiffEvenOddSum(int no)
        {
            if(no < 0)
            {
                no = -no;
            }
            iNo = no;
            
        }

        public void DiffSum()
        {
           AdditionEven ae = new AdditionEven(iNo);
           AdditionOdd ao = new AdditionOdd(iNo);

            iDiff = ae.iSum - ao.iSum;
        }

        public void display()
        {
           
            Console.WriteLine("Difference of Addition of Even And Odd Digits is : " + iDiff);
        }
    }
}
