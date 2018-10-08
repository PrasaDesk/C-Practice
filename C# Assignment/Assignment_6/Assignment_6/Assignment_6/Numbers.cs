using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Numbers : Marvellous
    {
        public Numbers(int ival) : base(ival)

        {
            int no = ival;

        }


        public override Boolean CheckStrong()
        {
            int idigit = 0;
            int isum = 0;
            int temp = base.ino;
            int num = temp;
            int n=1;
            while (num != 0)
            {
                n = 1;
                idigit = num % 10;
                for(int i=1;i<=idigit;i++)
                {
                    n = n * i;
                }
                isum = isum + n;
                num = num / 10;
            }
            if (isum == temp)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override Boolean CheckArmstrong()
        {
            int idigit = 0;
            int isum = 0;
            int temp= base.ino;
            int num = temp;
            int i;
            while (num != 0)
            {
                idigit = num % 10;
                i = idigit * idigit * idigit;
                isum = isum + i;
                num = num / 10;
            }
            
           if(temp==isum)
            {
                return true;
            }
           else
            {
                return false;
            }


        }
    }
}

    

