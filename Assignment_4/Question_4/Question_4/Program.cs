using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo;
            iNo = Convert.ToInt32(Console.ReadLine());

            WordNumber wn = new WordNumber(iNo);
            wn.displayNumToword();

        }
    }
}
