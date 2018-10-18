using System;

namespace CheckNumber
{
    public class ChkNumber
    {
        ////Prime Number //////////////////////////////////////////////////
        public bool IsPrime(int iNo)
        {
            int i = 0;
            for(i = 2;i <= iNo / 2; i++)
            {
                if(iNo % i == 0)
                {
                    break;
                }
            }
            if(i > (iNo / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ////Perfect Number ////////////////////////////////////////////////
        public bool IsPerfect(int iNo)
        {
            int i = 0, iSum = 0;
            for(i = 1;i <= iNo / 2; i++)
            {
                if(iNo % i == 0)
                {
                    iSum = iSum + i;
                }
            }
            if(iSum == iNo)
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
