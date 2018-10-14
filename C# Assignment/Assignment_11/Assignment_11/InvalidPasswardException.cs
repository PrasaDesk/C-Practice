using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    class InvalidPasswardException : Exception
    {
        public InvalidPasswardException(string exception) : base(exception)
        {
            Console.WriteLine("InvalidPasswardException : INVALID PASSWARD : {0}", exception);
        }
    }
}
