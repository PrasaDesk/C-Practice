using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12
{
    class Marvellous
    {
        public Marvellous()
        {

        }
        public void Fun()
        {
            int i = 0;
            Console.WriteLine("FUN");
            for (i = 0; i < 2000; i++)
            {
                Console.Write("{0} ", i);
            }
        }

        public void Gun()
        {
            int i = 0;
            Console.WriteLine("GUN");
            for (i = 0; i < 1000; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
