using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class MarvellousString
    {
        public string str;
        public MarvellousString(string name)
        {
            str = name;
        }
        public int strlenx()
        {
            int icnt = 0;
            foreach(char ch in str)
            {
                icnt = icnt + 1;
            }            
            return icnt;
        }
        
        public int CountCapital()
        {
            int icnt = 0;
            foreach (char ch in str)
            {
                if (ch >= 'A' &&  ch <= 'Z')
                    {
                    icnt = icnt + 1;
                }
            }                       
            return icnt;
        }
        
        public int CountSmall()
        {
            int icnt = 0;
            foreach (char ch in str)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    icnt = icnt + 1;
                }
            }                       
            return icnt;
        }
        
        public int Frequency(char ch1)
        {
            int icnt = 0;
            foreach (char ch in str)
            {
                if (ch ==ch1)
                {
                    icnt++;
                }
            }                       
            return icnt;
        }
        public int CountVowels()
        {
            int icnt = 0;
            foreach (char ch in str)
            {
                if (( ch == 'a') || ( ch == 'e') || (ch == 'i') || (ch == 'o') || ( ch == 'u') ||
                    (ch == 'A') || (ch == 'E') || (ch == 'I') || (ch == 'O') || (ch == 'U'))
                {
                    icnt ++;
                }
            }
            
            return icnt;
        }
        public int CountSpace()
        {
            int icnt = 0;
            foreach (char ch in str)
            {
                if (ch == ' ')
                {
                    icnt  ++;
                }
            }
                       
            return icnt;
        }
        public int SearchFirst(char ch1)
        {
            int i = 0;
            foreach (char ch in str)
            {
                i++;
                if (ch==ch1)
                {
                    break;
                }               
            }
            return i;
        }
       
        public int SearchLast(char ch1)
        {
            int i = 0;
            for (i = (str.Length - 1); i >= 0; i--)
            {
                if(str[i] == ch1)
                {
                    break;
                }
            }                     
            return i;           
        }
        public bool CheckPalindrome()
        {
            int i = 0;
            int j = str.Length - 1;
            while(i <= j)
            {
                if(str[i] != str[j])
                {
                    break;
                }
                i++; ;
                j--;
            }
            if(i > j)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
    }

}
