using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    class BloodGroupInvalidException:Exception
    {
        public BloodGroupInvalidException(string exception) : base(exception)
        {
            Console.WriteLine("BloodGroupInvalidException : {0}", exception);
        }
    }
}
