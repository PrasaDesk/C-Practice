using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_9
{
    class Question_2
    {
        public int iStart, iEnd;
        public Question_2(int val1, int val2)
        {
            iStart = val1;
            iEnd = val2;
        }

        public void PrintForward()
        {
            for (int i = iStart; i <= iEnd; i++)
            {
                Console.WriteLine("Forward print : {0}", i);
                Thread.Sleep(500);
            }
        }

        public void PrintBackward()
        {
            for (int i = iEnd; i >= iStart; i--)
            {
                Console.WriteLine("Backward print : {0}", i);
                Thread.Sleep(500);
            }
        }
    }
}
