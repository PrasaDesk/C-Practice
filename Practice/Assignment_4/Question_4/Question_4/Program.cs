using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo;
            Console.Write("Enter the Number :");
            iNo = Convert.ToInt32(Console.ReadLine());

            WordNumber wn = new WordNumber(iNo);
            Console.Write("Convert into Word : ");
            wn.displayNumToword();
            Console.WriteLine(" ");
        }
    }
}
