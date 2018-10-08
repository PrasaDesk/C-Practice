using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String ch;
            char ch1;
            int ret = 0;
            Console.WriteLine("Enter string");
            ch = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter A Single Charcter");
            ch1 = Convert.ToChar(Console.ReadLine());
            MarvellousString ob = new MarvellousString(ch);
            
            ret=ob.strlenx();
            Console.WriteLine("length of String is : " + ret);

            
            ret=ob.CountCapital();
            Console.WriteLine("Count of Capital character is " + ret);


            
            ret = ob.CountSmall();
            Console.WriteLine("Count of small character is " + ret);

            
            ret = ob.Frequency(ch1);
            Console.WriteLine("frequancy of character is "+ ret);

            
            ret = ob.CountVowels();
            Console.WriteLine("Count of Vowels is " + ret);



            ret = ob.CountSpace();
            Console.WriteLine("Count of space  is " + ret);


            ret = ob.SearchFirst(ch1);
            Console.WriteLine("first Position of character is " + ret);


            ret = ob.SearchLast(ch1);
            Console.WriteLine("last Position of character is " + ret);
                       
            if (ob.CheckPalindrome())
            {
                Console.WriteLine("String is Pallindrome");
            }
            else
            {
                Console.WriteLine("String is not Pallindrome");
            }
        }
    }
}
