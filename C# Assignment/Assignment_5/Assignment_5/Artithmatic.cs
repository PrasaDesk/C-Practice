using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    
    class Artithmatic
    {
        public int no1,no2;
        public Artithmatic(int x,int y)
        {
            no1 = x;
            no2 = y;
        }
        public int Add()
        {
            return no1 + no2;
        }
        public int Sub()
        {
            return no1 - no2;
        }
        public int Mult()
        {
            return no1 * no2;
        }
        public int Div()
        {
            return no1 / no2;
        }
    }
}
