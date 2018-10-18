using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Ques_
{
    class Numbers
    {
        public int size;
        public int[] arr;

        public Numbers()
        {
            size = 0;
            arr = new int[0];
        }

        public Numbers(int No)
        {
            size = No; 
            arr = new int[size];
        }

        public Numbers(Numbers obj)
        {
            this.size = obj.size;
            this.arr = obj.arr;
            Console.Write("\nObject Copied into Another Object\n\n");
        }

        public void Accept()
        {
            int i = 0;
            Console.Write("--$ Enter the Array Elements : \n");
            for(i = 0; i < size; i++)
            {
                Console.Write("Enter the array element for {0}th position : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n--$ Array Elements Accepted\n\n");
        }

        public void Display()
        {
            int i = 0;
            Console.Write("Displaying Array Elements.........!\n\n");
            for(i = 0; i < size; i++)
            {
                Console.Write("[{0}] ", arr[i]);
            }
            Console.Write("\nArray Finished...\n\n");
        }

    }
}
