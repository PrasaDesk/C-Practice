using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvellous_Calculator
{
    public class BitwiseOp
    {
       public int AndX(int iNo1, int iNo2)
        {
            return iNo1 & iNo2;
        }

        public int OrX(int iNo1, int iNo2)
        {
            return iNo1 | iNo2;
        }

        public int XorX(int iNo1, int iNo2)
        {
            return iNo1 ^ iNo2;
        }

        public int NotX(int iNo1)
        {
            return ~(iNo1);
        }
    }
}
