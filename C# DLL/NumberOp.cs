using System;

namespace CheckNumber
{
    namespace NumberOpration  //nasted namespace
    {
        public class NumberOp
        {
            public void IsEven(int iNo)
            {
                if (iNo % 2 == 0)
                {
                    Console.WriteLine("{0} is Even Number", iNo);
                }
                else
                {
                    Console.WriteLine("{0} is Not Even Number", iNo);
                }
            }

            public void IsOdd(int iNo)
            {
                if (iNo % 2 != 0)
                {
                    Console.WriteLine("{0} is Odd Number", iNo);
                }
                else
                {
                    Console.WriteLine("{0} is Not Odd Number", iNo);
                }
            }            
        }
    }    
}
