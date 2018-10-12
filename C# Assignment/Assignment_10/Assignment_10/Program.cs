using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int iValue = 0,iChoice,size;


            Console.Write("Enter Size of Array : ");
            size = Convert.ToInt32(Console.ReadLine());
            
            NumberFun nf = new NumberFun(size);
            nf.AcceptElemnets();
            

            Console.Write("Enter Your Choice : ");
            iChoice = Convert.ToInt32(Console.ReadLine());

            switch (iChoice)
            {
                case 1: //Question 1
                    Console.Write("Enter the Number : ");
                    iValue = Convert.ToInt32(Console.ReadLine());
                    Question_1 que1 = new Question_1(iValue);
                    Thread t1 = new Thread(que1.checkPrime);
                    Thread t2 = new Thread(que1.CheckPerfect);
           
                    t1.Start(); 
                    t2.Start();
                    break;

                case 2: //Question 2
                    Thread t3 = new Thread(nf.PrintArr);
                    Thread t4 = new Thread(nf.PrintOdd);
                    t3.Start();
                    t4.Start();
                    break;
                    
                case 3: //Question 3
                    Thread t5 = new Thread(nf.Max);
                    Thread t6 = new Thread(nf.Min);
                    t5.Start();
                    t6.Start();
                    break;

                default:
                    Console.WriteLine("INVALID INPUT....!!!");
                    break;
            }
        }
    }
}
