using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int iValue1, iValue2,iChoice;
            Console.Write("Enter Starting the Number : ");
            iValue1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Ending the Number : ");
            iValue2 = Convert.ToInt32(Console.ReadLine());

            Question_1 que1 = new Question_1(iValue1, iValue2);
            Question_2 que2 = new Question_2(iValue1, iValue2);

            Console.Write("Enter your Choice : ");
            iChoice = Convert.ToInt32(Console.ReadLine());
        
            switch (iChoice)
            {
                case 1: //Question 1
                    Thread t1 = new Thread(que1.PrintRange);
                    t1.Start();
                    break;

                case 2: //Question 2
                    Thread t2 = new Thread(que2.PrintForward);
                    Thread t3 = new Thread(que2.PrintBackward);
                    t2.Start();
                    t3.Start();
                    break;

                case 3: //Question 3
                    Thread t4 = new Thread(que1.PrintRange);
                    t4.Name = "PrintRangeMethod";
                    Console.WriteLine("Thread Name     : " + t4.Name);
                    Console.WriteLine("ID              : " + t4.ManagedThreadId);
                    Console.WriteLine("Priority        : " + t4.Priority);
                    Console.WriteLine("Execution Context : " + t4.ExecutionContext);
                    
                    break;

                case 4: //Question 4
                    Thread t5 = new Thread(que2.PrintForward);
                    Thread t6 = new Thread(que2.PrintBackward);
                    t5.Start();
                    //t6.Start();
                    t5.Join();
                    t6.Start();
                    break;

                default :
                    Console.Write("Invalid Input\n");
                    break;
            }
        }
    }
}
