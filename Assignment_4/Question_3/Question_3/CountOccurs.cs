using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    class CountOccurs
    {
        public int iNo, cnt;

        public CountOccurs(int no)
        {
            if (no < 0)
            {
                no = -no;
            }
            iNo = no;
            cnt = 0;
        }

        public void Count5()
        {
            while (iNo != 0)
            {
                if((iNo % 10) == 5)
                {
                    cnt++;
                }
                iNo = iNo / 10;
            }
        }

        public void display()
        {
            Console.WriteLine("Occurance of digit 5 is : "+cnt);
        }
    }
}
