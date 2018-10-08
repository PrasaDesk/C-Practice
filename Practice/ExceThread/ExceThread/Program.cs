using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExceThread
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo = 0;

            Console.Write("Enter the NUmber : ");
            iNo = Convert.ToInt32(Console.ReadLine());
            /*
            try
            {
                iNo = Convert.ToInt32(Console.ReadLine());
            }
            catch(NegativeNumberException e)
            {
                Console.WriteLine(e);
            }
            */

            Numbers obj = new ConNumbers(iNo);

            Thread t1 = new Thread(obj.DisplayEven);
            Thread t2 = new Thread(obj.DisplayOdd);
            Thread t3 = new Thread(obj.DisplayPrime);
            Thread t4 = new Thread(obj.Factorial);
            t1.Name = "DisplayEven";
            t2.Name = "DisplayOdd";
            t3.Name = "DisplayPrime";
            t4.Name = "Factorial";

            t1.Start();
            //t1.Join();
            
            Console.WriteLine("THREAD Name : "+ t1.Name);
            Console.WriteLine("THREAD Priority : "+ t1.Priority);
            Console.WriteLine("THREAD ID : "+ t1.ManagedThreadId);

            if (t1.IsBackground)
            {
                Console.WriteLine("t1 thread is in Background");
            }
            else
            {
                Console.WriteLine("t1 thread not in Background");
            }

            if (t1.IsAlive)
            {
                Console.WriteLine("t1 thread is ALIVE");
            }
            else
            {
                Console.WriteLine("t1 thread NOT in ALIVE");
            }

            if (t1.IsThreadPoolThread)
            {
                Console.WriteLine("t1 thread is POOLTHREAD");
            }
            else
            {
                Console.WriteLine("t1 thread NOT in POOLTHREAD");
            }

            Console.WriteLine("Executionn context : "+ t1.ExecutionContext);

            
            //t1.Start();
      
            t2.Start();
            t2.Join();

            t3.Start();
            t3.Join();

            t4.Start();
            t4.Abort();

            //as keyword uses

            ConNumbers con = new ConNumbers(iNo);
            Console.WriteLine("Use of --- as --- keyword");
            Console.WriteLine((con as Numbers).iNo + " == Using --- as ---");

        }
    }
}
