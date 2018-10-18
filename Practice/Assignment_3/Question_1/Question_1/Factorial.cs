using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Factorial
    {
        public int iNo;
        public int iFact;

        public Factorial(int no)
        {
            iNo = no;
            iFact = 1;
        }

        public void fact()
        {
            while(iNo != 1)
            {
                iFact = iFact * iNo;
                iNo--;
            }
        }

        public void display()
        {
            Console.WriteLine("Factorial is " + iFact);
        }

    }
}
