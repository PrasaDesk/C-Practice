using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceThread
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException(String str):base(str)
        {
            Console.WriteLine("NegativeNumberException : {0}", str);
        }
    }
}
