using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    class Reverse
    {
        public int iNo,rev,iDigit;

        public Reverse(int no)
        {
            if(no < 0)
            {
                no = -no;
            }
            iNo = no;
            rev = 0;
            iDigit = 0;
        }

        public void ReversePrint()
        {
            while(iNo != 0)
            {
                iDigit = iNo % 10;
                rev = rev * 10 + iDigit;
                iNo = iNo / 10;
            }
        }

        public void display()
        {
            Console.WriteLine("Reverse number is : " + rev);
        }

    }
}
