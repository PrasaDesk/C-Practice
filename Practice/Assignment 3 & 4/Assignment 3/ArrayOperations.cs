using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Ques_
{
    class ArrayOperations : Numbers
    {
        public int Max, Min;
        public Numbers Num;
      //  public int[] arr;


        public ArrayOperations(int No)
        {
            Num = new Numbers(No);
            Num.Accept();
            Num.Display();
        }
        
        /*  //By Passing Object
        public ArrayOperations(Numbers obj)
        {
            Num = new Numbers(obj);
            Console.Write("Array Size is {0} \n", Num.size);       
        }
        */

        public void Maximum()
        {
            int i = 0;
            Max = Num.arr[0];
            
            for (i = 0;i < Num.size; i++)
            {
                //Console.Write("{0}  ", Num.arr[i]);
                if(Max < Num.arr[i])
                {
                    Max = Num.arr[i];
                }
            }
        }

        public void Minimum()
        {
            int i = 0;
            Min = Num.arr[0];
            for (i = 0;i < Num.size; i++)
            {
                if(Min > Num.arr[i])
                {
                    Min = Num.arr[i];
                }
            }
        }

        public void Display()
        {
            Console.Write("-------------------------------------------------\n");
            Console.Write("\nSmallest Element from Array is {0}\n",Min);
            Console.Write("\nLargest Element from Array is {0}\n", Max);
            Console.Write("-------------------------------------------------\n");
        }

    }
}
