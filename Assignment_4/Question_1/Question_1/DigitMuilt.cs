using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class DigitMuilt
    {
        public int iNo,iMult,iDigit;

        public DigitMuilt(int no)
        {
            if(no < 0)
            {
                no = -no;
            }
            iNo = no;
            iMult = 1;
        }

        public void Multi()
        {
            while(iNo != 0)
            {
                iDigit = iNo % 10;
                if(iDigit == 0)
                {
                    iMult = iMult * 1;
                }
                else
                {
                    iMult = iMult * iDigit;
                }
                iNo = iNo / 10;
            }
        }

        public void Display()
        {
            Console.WriteLine("Multiplication of Digits is : " + iMult);
        }


    }
}
