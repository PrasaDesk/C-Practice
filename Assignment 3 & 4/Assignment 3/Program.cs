using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Ques_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num = 0,iNo = 0;
            /*
            Console.Write("#############################################################################################\n\n");
            Console.Write("Default Constructor\n");
            Numbers obj1 = new Numbers();
            obj1.Accept();
            obj1.Display();
            

            Console.Write("#############################################################################################\n\n");
            Console.Write("Prametrized Constructor::::::\n\n");
            Console.Write("Enter the no of Elements : ");
            num = Convert.ToInt32(Console.ReadLine());
            Numbers obj2 = new Numbers(num);
            obj2.Accept();
            obj2.Display();
            Console.Write("#############################################################################################\n");
            

            Console.Write("\nCopy Constructor\n");
            Numbers obj3 = new Numbers(obj2);
            obj3.Display();

            Console.Write("#############################################################################################\n");
            */

            Console.Write("\nArray Operations\n\n");
            
            Console.Write("Enter the no of Elements : ");
            num = Convert.ToInt32(Console.ReadLine());

            ArrayOperations ao = new ArrayOperations(num);
            ao.Maximum();
            ao.Minimum();
            ao.Display();

            //Numbers n = new ArrayOperations();


            Console.Write("Enter the no of Elements : ");
            num = Convert.ToInt32(Console.ReadLine());
            
            ArrayCombine ac = new ArrayCombine(num);

            Console.Write("Enter the Number : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            ac.Search(iNo);
            ac.Frequency(iNo);
            ac.Sumation();
            ac.Average();
            ac.Display();

        }
    }
}
