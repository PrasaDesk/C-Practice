using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int no = 0;
            int a = 0;
            int b = 0;
            Boolean bRet ;
            int iRet = 0;

            Console.Write("Enter the Number : ");
            no = Convert.ToInt32(Console.ReadLine());

            Program obj = new Program();
            Numbers ob = new Numbers(no);
            
           bRet=ob.CheckArmstrong();
            if (bRet == true)
            {
                Console.WriteLine("It is Amstrong No");

            }
            else
            {
                Console.WriteLine("It is not a Amstrong Number");
            }

            
            bRet=ob.CheckStrong();
            if (bRet == true)
            {
                Console.WriteLine("It is strong No");

            }
            else
            {
                Console.WriteLine("It is not a strong Number");
            }
            
            iRet=ob.CountDigit(no);
            Console.WriteLine("Count of Digit is {0}",iRet);
            
            iRet=ob.SumFactor(no);
            Console.WriteLine("Sum of Factor is {0}", iRet);
            
            Console.WriteLine("Enter the Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power of Number");
            b = Convert.ToInt32(Console.ReadLine());
            iRet=ob.Power(a,b);
            Console.WriteLine("power of number is {0}", iRet);
        }
    }
}
