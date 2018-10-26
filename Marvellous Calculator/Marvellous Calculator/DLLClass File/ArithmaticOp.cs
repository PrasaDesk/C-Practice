using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvellous_Calculator
{
    public class ArithmaticOp
    {
        public T AddX<T>(T iNo1, T iNo2)
        {
            dynamic a = iNo1;
            dynamic b = iNo2;

            return a + b;
        }

        public T SubX<T>(T iNo1, T iNo2)
        {
            dynamic a = iNo1;
            dynamic b = iNo2;
            return a - b;
        }

        public T MultX<T>(T iNo1, T iNo2)
        {
            dynamic a = iNo1;
            dynamic b = iNo2;
            return a * b;
        }

        public T DivX<T>(T iNo1, T iNo2)
        {
            
            dynamic a = iNo1;
            dynamic b = iNo2;
            if(b == 0)
            {
                return b;
            }
            return a / b;           
        }

        public T ModX<T>(T iNo1, T iNo2)
        {
            dynamic a = iNo1;
            dynamic b = iNo2;
            return a % b;
        }
    }
}
