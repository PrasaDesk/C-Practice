using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    class Question_1
    {
        public int iNo;
        public Question_1(int val)
        {
            iNo = val;
        }

        public void checkPrime()
        {
            bool f = true;
            for(int i = 2;i <= (iNo / 2); i++)
            {
                if((iNo % i) == 0)
                {
                    f = false;
                    break;
                }
            }
            if(f == true)
            {
                Console.WriteLine("Given Number is Prime Number.");
            }
            else
            {
                Console.WriteLine("Given Number is Not a Prime Number.");
            }
        }

        public void CheckPerfect()
        {
            int iSum = 0;
            for (int i = 1; i <= (iNo / 2); i++)
            {
                if((iNo % i) == 0)
                {
                    iSum = iSum + i;
                }
            }
            if(iSum == iNo)
            {
                Console.WriteLine("Given Number is Perfect Number.");
            }
            else
            {
                Console.WriteLine("Given Number is Not a Perfect Number.");
            }
        }
    }
}
