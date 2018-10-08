using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_6_Que_2
{
   abstract class MarvellousRange
    {
        public int iStart;
        public int iEnd;
        public MarvellousRange(int val1, int val2)
        {
            iStart = val1;
            iEnd = val2;
        }
        // Abstract method declarations
        public abstract int SumRange();
        public abstract void DisplayEven();
        public abstract void DisplayOdd();
        public abstract void DisplayPrime();
        public abstract void DisplayPerfect();
    }
}
