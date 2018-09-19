using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    class Range
    {
        public int iNo1, iNo2,iCnt;
        public Range(int no1,int no2)
        {
            iNo1 = no1;
            iNo2 = no2;
        }

        public void displayRange()
        {
            for(iCnt = iNo1;iCnt <= iNo2; iCnt++)
            {
                Console.Write(iCnt + " ");
            }
        }

    }
}
