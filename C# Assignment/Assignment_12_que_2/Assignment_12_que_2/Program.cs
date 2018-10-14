using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12_que_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iChoice;

            Console.WriteLine("1: Check Age\n2: Check Designation\n3: Exit\n");
            Console.Write("Enter your Choice : ");
            iChoice = Convert.ToInt32(Console.ReadLine());

            switch (iChoice)
            {
                case 1:
                    ChkAge ca = new ChkAge();
                    ca.Accept();
                    ca.CalculateAge();
                    break;

                case 2:
                    Console.WriteLine("\n\nDesignation:\n");
                    ChkDesignation cd = new ChkDesignation();
                    cd.Accept();
                    cd.ShowDesignation();
                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("INVALID INPUT");
                    break;
            }           
        }
    }
}
