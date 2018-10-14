using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    class InvalidNameException : Exception
    {
        public InvalidNameException(string exception) : base(exception)
        {
            Console.WriteLine("InvalidNameException : {0}", exception);
        }
    }
}
