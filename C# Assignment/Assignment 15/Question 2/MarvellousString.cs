using System;

namespace MStrings
{
    public class MarvellousString
    {
        public void LargeWordX(string str)
        {
            int i = 0, cnt = 0,tcnt = 0, x, start = 0,end = 0;

            while(i < str.Length-1)
            {
                if (str[i] == ' ')
                {
                    while (i != str.Length && str[i] == ' ')
                    {
                        i++;
                    }
                }

                if (str[i] != ' ')
                {
                   x = i;
                   tcnt = 0;
                   while (i != str.Length && str[i] != ' ')
                    {
                        tcnt++;
                        i++;

                    }
                   if(cnt < tcnt)
                   {
                        cnt = tcnt;
                        start = x;
                        end = i;
                   }
                }

            }
            for(i = start;i < end; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine("");
        }

        public bool ChkPalindrome(string str)
        {
            int i = 0, j = str.Length - 1;
            str = str.ToUpper();
            string temp = str;
            while(i <= j)
            {
                if(str[i] != temp[j])
                {
                    break;
                }
                i++;
                j--;
            }
            if (i < j)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
