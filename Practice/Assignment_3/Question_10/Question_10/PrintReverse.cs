using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_10
{
    class PrintReverse
    {
        public int iStart, iEnd,iCnt;

        public void Accept()
        {
            Console.Write("Enter Starting Number: ");
            iStart = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number Where we End : ");
            iEnd = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayRev()
        {
            for(iCnt = iEnd;iCnt >= iStart; iCnt--)
            {
                Console.Write(iCnt + " ");
            }
        }

    }
}
