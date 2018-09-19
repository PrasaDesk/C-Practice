using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_9_and_10
{
    class AdditionOdd
    {
        public int iNo, iSum;

        public AdditionOdd(int no)
        {
            if(no < 0)
            {
                no = -no;
            }
            iNo = no;
        }

        public void OddSum()
        {
            while (iNo != 0)
            {
                if (((iNo % 10) % 2) != 0)
                {
                    iSum = iSum + (iNo % 10);
                }
                iNo = iNo / 10;
            }
        }

        public void display()
        {
            Console.WriteLine("Addition of Odd digits : " + iSum);
        }
    }
}
