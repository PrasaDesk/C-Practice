using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo1 = 0;
            Console.Write("Enter The Number ");
            iNo1 = Convert.ToInt32(Console.ReadLine());

            DigitMuilt dm = new DigitMuilt(iNo1);
            dm.Multi();
            dm.Display();
            Console.WriteLine(" ");

        }
    }
}
