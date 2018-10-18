using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNumTemplates
{
    abstract class NumTemplates
    {
        public int No;

        public NumTemplates()
        {
            No = 0;
        }
        public NumTemplates(int val)
        {
            No = val;
        }

        public abstract void Accept();
        public abstract void Display();
        public abstract bool ChkEven();
        public abstract void DisplayFactor();
        public abstract void SumFactor();
    }
}
