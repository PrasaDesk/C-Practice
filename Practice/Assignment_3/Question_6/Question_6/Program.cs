using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo = 0;
            Console.Write("Enter the Number : ");
            iNo = System.Convert.ToInt32(Console.ReadLine());

            Convert cn = new Convert(iNo);
            cn.toBinary();
            


        }
    }
}
