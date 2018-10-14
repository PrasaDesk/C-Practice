using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12
{
    class Program
    {
        static void Main(string[] args)
        {
            String starttime = DateTime.Now.ToString();
            Console.WriteLine("Start time : {0}", starttime);

            var stopWatch = System.Diagnostics.Stopwatch.StartNew();
            stopWatch.Start();

            Marvellous mobj = new Marvellous();
            mobj.Fun();
            mobj.Gun();

            String Endtime = DateTime.Now.ToString();
            Console.WriteLine("Start time : {0}", Endtime);

            stopWatch.Stop();
            Console.WriteLine("Execution Time : {0} ms",stopWatch.ElapsedMilliseconds);
        }
    }
}
