using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    class ChkPswd
    {
        public string pswd;
        public ChkPswd(string str)
        {
            if(str.Length < 7)
            {
                throw new InvalidPasswardException("Passward Length is Short");
            }
            pswd = str;
        }

        public Boolean ChkPassward()
        {
            int Cap = 0,small = 0,Num = 0;
            for (int i = 0; i < pswd.Length; i++)
            {
                if(pswd[i] >= 'A' && pswd[i] <= 'Z')
                {
                    Cap++;
                }
                else if(pswd[i] >= 'a' && pswd[i] <= 'z')
                {
                    small++;
                }
                else if(pswd[i] >= '0' && pswd[i] <= '9')
                {
                    Num++;
                }
            }
            if((Cap < 3) || (small < 2) || (Num < 2))
            { 
                throw new InvalidPasswardException("Passward Dose Not Follow Rules. Passward Doesn't contain 3 capitals/2 small/2 numbers");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
