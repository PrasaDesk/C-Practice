using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_9
{
    class sum
    {
        public int iNo1, iNo2,iCnt,iSum;

        public sum(int no1,int no2)
        {
            iNo1 = no1;
            iNo2 = no2;
        }

        public void addition()
        {
            for(iCnt = iNo1;iCnt <= iNo2; iCnt++)
            {
                iSum = iSum + iCnt;
            }
            Console.WriteLine("Sum of Elements : " + iSum);
        }

    }
}
