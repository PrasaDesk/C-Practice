using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionn_4
{
    class Average
    {
        public int iNo1,iNo2,iNo3;
        public int avg;

        public Average(int no1,int no2,int no3)
        {
            iNo1 = no1;
            iNo2 = no2;
            iNo3 = no3;
        }

        public void Avg()
        {
            avg = (iNo1 + iNo2 + iNo3) / 3;
        }

        public void display()
        {
            Console.WriteLine("Average is : "+avg);
        }

    }
}
