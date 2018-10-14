using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    class AgeInvalidException:Exception
    {
        public AgeInvalidException(string exception) : base(exception)
        {
            Console.WriteLine("AgeInvalidException : {0}", exception);
        }
    }
}
