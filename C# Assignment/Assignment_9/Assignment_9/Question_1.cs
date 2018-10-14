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
        public void PrintRange(int iStart,int iEnd)
        {
            for (int i = iStart; i <= iEnd; i++)
            {
                Console.WriteLine("Printing Range Elements : {0}", i);
                Thread.Sleep(100);
            }
        }
    }
}
