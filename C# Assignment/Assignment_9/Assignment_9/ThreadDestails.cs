using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_9
{
    class ThreadDestails
    {
        public void Details()
        {
            Thread t1 = Thread.CurrentThread;
            t1.Name = "ThreadDetails Thread";
            Console.WriteLine("Thread Name : {0}", t1.Name);
            Console.WriteLine("Thread ID   : {0}", t1.ManagedThreadId);
            Console.WriteLine("Priority    : {0}", t1.Priority);
            Console.WriteLine("Status      : {0}", t1.ExecutionContext);
        }
    }
}
