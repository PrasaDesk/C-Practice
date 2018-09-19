using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
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

        public void Count0()
        {
            while (iNo != 0)
            {
                if ((iNo % 10) == 0)
                {
                    cnt++;
                }
                iNo = iNo / 10;
            }
        }

        public void display()
        {
            Console.WriteLine("Occurance of digit 0 is : " + cnt);
        }
    }
}
