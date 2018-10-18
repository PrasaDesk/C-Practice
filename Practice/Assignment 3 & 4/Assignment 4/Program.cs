using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNumTemplates
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prime, perfect;
            NumOperation nt = new NumOperation();
            nt.Accept();
            nt.ChkEven();
            nt.SumFactor();
            nt.Display();
            nt.DisplayFactor();


            // NumberActivity na = new NumberActivity();

            NumberActivity na = new NumberActivity(nt);

            Console.WriteLine("-----------------------------------------------------------------\n");
            na.Factorial();
            na.Display();
            Console.WriteLine("-----------------------------------------------------------------\n");
            prime = na.ChkPrime();
            if (prime == true)
            {
                Console.WriteLine("Give Number is Prime Number.\n");
            }
            else
            {
                Console.WriteLine("Give Number is Not a Prime Number.\n");
            }
            Console.WriteLine("-----------------------------------------------------------------\n");
            perfect = na.ChkPerfect();
            if (perfect == true)
            {
                Console.WriteLine("Give Number is Perfect Number.\n");
            }
            else
            {
                Console.WriteLine("Give Number is Not a Perfect Number.\n");
            }
            Console.WriteLine("-----------------------------------------------------------------\n");
        }
    }
}
