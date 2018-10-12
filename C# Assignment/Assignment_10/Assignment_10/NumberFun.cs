using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    // Question 3
    class NumberFun : NumberArr
    {
        public NumberFun(int iNo) : base(iNo)
        {
        }

        public void Max()
        {
            int iMax = 0;
            for (int i = 0; i < base.iSize; i++)
            {
                if(iMax < base.Arr[i])
                {
                    iMax = base.Arr[i];
                }
            }
            Console.WriteLine("Maximum Number from Array is : {0}", iMax);
        }

        public void Min()
        {
            int iMin = base.Arr[0];
            for (int i = 1; i < base.iSize; i++)
            {
                if (iMin > base.Arr[i])
                {
                    iMin = base.Arr[i];
                }
            }
            Console.WriteLine("Minimum Number from Array is : {0}", iMin);
        }
    }
}
