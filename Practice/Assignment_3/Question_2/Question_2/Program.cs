using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Amt = 0.0f , Rate = 0.0f;
            int time = 0;

            Console.Write("Enter Amount and Rate of interset : ");
            Amt = Convert.ToDouble(Console.ReadLine());
            Rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nenter Time : ");
            time = Convert.ToInt32(Console.ReadLine());

            simpleIntreset si = new simpleIntreset(Amt,Rate,time);
            si.simpleInt();
            si.display();

        }
    }
}