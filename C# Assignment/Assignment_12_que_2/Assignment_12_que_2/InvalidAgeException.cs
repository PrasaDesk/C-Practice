using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12_que_2
{
    class InvalidAgeException:Exception
    {
        public InvalidAgeException(string exception) : base(exception)
        {
            Console.WriteLine("InvalidAgeException : {0}", exception);
        }
    }
}
