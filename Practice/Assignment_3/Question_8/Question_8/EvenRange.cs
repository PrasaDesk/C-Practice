using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_8
{
    
    class EvenRange
    {
        public int iNo1,iNo2, iEven,icnt;

        public EvenRange(int no1,int no2)
        {
            iNo1 = no1;
            iNo2 = no2;
        }

        public void DisplayEven()
        {
            for(icnt = iNo1;icnt <= iNo2; icnt++)
            {
                if((icnt % 2) == 0)
                {
                    Console.Write(icnt + " ");
                }
            }
        }

    }
}
