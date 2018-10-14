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
        public void PrintForward(int iStart,int iEnd)
        {
            for (int i = iStart; i <= iEnd; i++)
            {
                Console.WriteLine("Forward print : {0}", i);
                
            }
        }

        public void PrintBackward(int iStart, int iEnd)
        {
            for (int i = iEnd; i >= iStart; i--)
            {
                Console.WriteLine("Backward print : {0}", i);
                
            }
        }
    }
}
