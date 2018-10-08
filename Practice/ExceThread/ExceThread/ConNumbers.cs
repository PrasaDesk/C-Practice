using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExceThread
{
    class ConNumbers : Numbers
    {
        public ConNumbers(int value) : base(value)
        {
            Console.WriteLine(value + " Send to Base Class\n");
        }


        public override void DisplayEven()
        {
            int i = 0;
            try
            {
                for (i = 1; i <= base.iNo; i++)
                {
                    if ((i % 2) == 0)
                    {
                        Console.WriteLine("Even Number : " + i);
                    }
                    Thread.Sleep(1000);
                }
                 
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e);
            }
        }
        public override void DisplayOdd()
        {
            int i = 0;
            try
            {
                for (i = 1; i <= base.iNo; i++)
                {
                    if ((i % 2) != 0)
                    {
                        Console.WriteLine("Odd Number : " + i);
                    }
                    Thread.Sleep(1000);
                }                
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e);
            }
        }

        
        public override void DisplayPrime()
        {
            try
            {
                for (int i = 1; i <= base.iNo; i++)
                {
                    int f = 0;
                    for (int j = 2; j <= (i / 2); j++)
                    {
                        if (i % j == 0)
                        {
                            f = 1;
                            break;
                        }
                    }
                    if (f == 0)
                        {
                        Console.WriteLine("Prime Number is : " + i);
                        }
                    Thread.Sleep(1000);
                }
                
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
        }

        public override void Factorial()
        {
            int i = 0;
            checked
            {
                try
                {
                    int iSum = 1;
                    for (i = 1; i <= base.iNo; i++)
                    {                        
                        iSum = 1;
                        for (int j = 1; j <= i; j++)
                        {
                            iSum = iSum * j;
                        }
                        Console.WriteLine("Factorial of {0} is {1}", i, iSum);
                        Thread.Sleep(1000);
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("We Get A Exception Because we Try to find out Factorial of {0}", i);
                    Console.WriteLine(e);
                }
                finally
                {
                    Console.WriteLine("Factorial Executed....!!!");
                }
            }
        }
    }
}
