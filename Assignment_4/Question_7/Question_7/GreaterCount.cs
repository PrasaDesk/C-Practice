using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    class GreaterCount
    {
        public int iNo,cnt;

        public GreaterCount(int no)
        {
            if(no < 0)
            {
                no = -no;
            }
            iNo = no;
            cnt = 0;
        }

        public void CountGreater5()
        {
            while(iNo != 0)
            {
                if ((iNo % 10) > 5)
                {
                    cnt++;
                }
                iNo = iNo / 10;
            }
        }

        public void display()
        {
            Console.WriteLine("Count of Digits Greater then 5 : " + cnt);
        }

    }
}
