using System;

namespace ArrayOperation
{
    public class OpArray
    {
        public int[] Arr;
        public int size;
        public OpArray(int x)
        {
            Arr = new int[x];
            size = x; 
            for(int i = 0;i < size; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayArr()
        {
            for(int i = 0;i < size; i++)
            {
                Console.Write("[{0}] ", Arr[i]);
            }
            Console.WriteLine("");
        }
    }
}
