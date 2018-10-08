using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceThread
{
    abstract class Numbers
    {
        public int iNo;
        public Numbers(int value)
        {
            if(value < 0)
            {
                throw new NegativeNumberException("Invalid Input : " + value + " -- Please Give Positive Integer.");
            }
            else
            {
                iNo = value;
            }
           
        }

        abstract public void DisplayEven();
        abstract public void DisplayOdd();
        abstract public void DisplayPrime();
        abstract public void Factorial();
    }
}
