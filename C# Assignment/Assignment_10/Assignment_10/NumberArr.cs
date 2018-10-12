using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    //Question 2
    class NumberArr
    {
        public int[] Arr;
        public int iSize;
               
        public NumberArr(int iNo)
        {
            iSize = iNo;
            Arr = new int[iSize];
        }

        public void AcceptElemnets()
        {
            Console.WriteLine("Enter Array Elements :");
            for (int i = 0; i <= iSize - 1; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* for (int i = 0; i <= iSize - 1; i++)
             {
                 Console.WriteLine(Arr[i]);
             }*/
        }

        public void PrintArr()
        {
            for (int i = 0; i <= iSize - 1; i++)
            {
                Console.WriteLine("Position : {0}   Array element : {1}", i, Arr[i]);
            }
        }

        public void PrintOdd()
        {
            for (int i = 0; i <= iSize - 1; i++)
            {
                if(Arr[i] % 2 != 0)
                {
                    Console.WriteLine("Position : {0}   Array Odd element : {1}", i, Arr[i]);
                }                
            }
        }
    }
}
