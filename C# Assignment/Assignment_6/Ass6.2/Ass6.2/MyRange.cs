using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_6_Que_2
{
    class MyRange : MarvellousRange
    {
        public MyRange(int value1, int value2) :base(value1,value2)
        {
             int no1 = value1;
            int no2 = value2;
         }
    public override int SumRange()
    {
            int i = 0;
            int sum = 0;
            for(i=base.iStart;i<=base.iEnd;i++)
            {
                sum = sum + i;
            }
            return sum;
    }
    public override void DisplayEven()
    {
            int i = 0;
            Console.Write("\nEven Numbers : ");
            for (i = base.iStart; i <= base.iEnd; i++)
            {
                if(i%2==0)
                {
                    Console.Write(i + " ");
                }
            }
        }

    
    public override void DisplayOdd()
    {
            int i = 0;
            Console.Write("\nOdd Numbers : ");
            for (i = base.iStart; i <= base.iEnd; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    public override void DisplayPrime()
    {
            int i = 0 , j = 0;
            int f = 1;
            Console.Write("\nPrime Numbers : ");
            for(i = iStart; i <= iEnd;i++)
            {
                f = 1;
                for (j = 2; j <= i / 2; j++)
                {
                    if(i % j == 0)
                    {
                        f = 0;
                        break;
                    }
                } 
                if(f == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    public override void DisplayPerfect()
    {
            int i = 0;
            int j = 0;
            int sum = 0,f = 0;
            Console.Write("\nPerfect No : ");
            for (i = iStart; i <= iEnd; i++)
            {
                sum = 0;
                for (j = 1; j <= (i / 2); j++)
                {
                    if((i % j) == 0)
                    {
                        sum = sum + j;
                    }
                }
                if(sum == i)
                {
                    f = 1;
                    Console.Write(i + " ");
                }
            }
            if(f == 0)
            {
                Console.Write("There is No Perfect NUmber Between The Range\n");
            }
            
        }
}
}
