using System;
using MStrings;
using MNumbers;

namespace ConsoleApp3
{
    class Client
    {
        static void Main(string[] args)
        {
            string str;
            int iNo = 0;
            MarvellousString ms = new MarvellousString();
            
            Console.Write("Enter the string for Print Largest Number from That string : ");
            str = Console.ReadLine();
            ms.LargeWordX(str);

            Console.Write("Enter The string Check Planidrom : ");
            str = Console.ReadLine();
            if (ms.ChkPalindrome(str))
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is Not Palindrome");
            }

            Console.Write("Enter the Number : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            MarvellousNumbers mn = new MarvellousNumbers(iNo);
            mn.BinaryX();
            mn.OctalX();
            mn.HexX();
        }
    }
}
