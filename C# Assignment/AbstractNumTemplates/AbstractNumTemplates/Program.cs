using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNumTemplates
{
    class Program
    {
        static void Main(string[] args)
        {
            NumTemplates nt = new NumOperation();
            nt.Accept();
            nt.ChkEven();
            nt.SumFactor();
            nt.Display();
            nt.DisplayFactor();
        }
    }
}
