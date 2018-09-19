using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    class LargestFactor
    {
        public int iNo1,iNo2;
        public int ifact;

        public LargestFactor(int no1,int no2)
        {
            iNo1 = no1;
            iNo2 = no2;
        }

        public void Factor()
        {
            int i = 1;

            while(i <= (iNo1/2) && i <= (iNo2 / 2))
            {
                if(((iNo1 % i) == 0) && ((iNo2 % i) == 0))
                    {
                    if(ifact < i)
                    {
                        ifact = i;
                    }
                }
                iNo1++;
                iNo2++;
            }
        }

        public void Display()
        {
            Console.WriteLine("Largest common Factor is : "+ifact);
        }

    }
}
