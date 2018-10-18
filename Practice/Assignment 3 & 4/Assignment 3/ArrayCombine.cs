using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Ques_
{
    class ArrayCombine : Numbers
    {
        public int iCnt,iSum,iAvg;
        public Numbers Num;
        
        public ArrayCombine(int ino)
        {
            Num = new Numbers(ino);
            Console.Write("Array Size is {0} \n", Num.size);
            Num.Accept();
            Num.Display();
            iSum = 0;
            iAvg = 0;
        }


        public void Search(int no)
        {
            int i = 0;
            Console.Write("\nNumber at this Positions : ");
            for(i = 0;i < Num.size; i++)
            {
                if(Num.arr[i] == no)
                {
                    Console.Write(i+" ");
                }
            }
            Console.Write("\n\n");            
        }

        public void Frequency(int no)
        {
            int i = 0;
            for (i = 0; i < Num.size; i++)
            {
                if (Num.arr[i] == no)
                {
                    iCnt++;
                }
            }
        }

        public void Sumation()
        {
            int i = 0;
            for (i = 0; i < Num.size; i++)
            {
                iSum = iSum + Num.arr[i];
            }
        }

        public void Average()
        {
            int i = 0,sum = 0;
            for (i = 0; i < Num.size; i++)
            {
                sum = sum + Num.arr[i];
            }
            iAvg = (sum / Num.size);
        }

        public void Display()
        {
            Console.WriteLine("\n\nFreaquency of Number is : {0}", iCnt);
            Console.WriteLine("\n\nSumationn of array elements is : {0}", iSum);
            Console.WriteLine("\n\nAverage is : {0}", iAvg);

        }

    }
}
