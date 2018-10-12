using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_9
{
    class Question_1
    {
        public int iStart,iEnd;
        public Question_1(int val1,int val2)
        {
            iStart = val1;
            iEnd = val2;
        }

        public void PrintRange()
        {
            for (int i = iStart; i <= iEnd; i++)
            {
                Console.WriteLine("Printing Range Elements : {0}", i);
                Thread.Sleep(500);
            }
        }
    }
}
