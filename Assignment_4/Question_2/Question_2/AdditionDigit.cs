using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class AdditionDigit
    {
        public int iNo,iSum;

        public AdditionDigit(int no)
        {
            if(no < 0)
            {
                no = -no;
            }
            iNo = no;
            iSum = 0;
        }

        public void Addition()
        {
            while(iNo != 0)
            {
                iSum = iSum + (iNo % 10);
                iNo = iNo / 10;
            }
        }

        public void display()
        {
            Console.WriteLine("Addition of Digits is : " + iSum);
        }

    }
}
