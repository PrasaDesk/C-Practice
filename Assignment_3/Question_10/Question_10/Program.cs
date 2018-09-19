//Accept Range form user and print number in Reverse order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReverse pr = new PrintReverse();
            pr.Accept();
            pr.DisplayRev();
            Console.WriteLine(" ");
        }
    }
}
