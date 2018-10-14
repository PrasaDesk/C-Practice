using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string Passward;
            Boolean bRet;
            int iChoice = 0;

            Console.Write("Question 1 : 1\nQuestion 2 : 2\nEnter the Choice :  ");
            iChoice = Convert.ToInt32(Console.ReadLine());

            switch (iChoice)
            {
                case 1:

                    Console.Write("Enter the Passward :  ");
                    Passward = Console.ReadLine();

                    ChkPswd cp = new ChkPswd(Passward);

                    bRet = cp.ChkPassward();
                    if (bRet == true)
                    {
                        Console.WriteLine("Passward Accepted");
                    }
                    break;

                case 2:
                    EmployeeDetails ed = new EmployeeDetails();
                    ed.Accept();
                    ed.DisplayDetails();
                    break;
                default :
                    Console.WriteLine("INVALID INPUT");
                    break;

            }      
                   
        
        }
    }
}
