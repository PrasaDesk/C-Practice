using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
     abstract class Marvellous
    {
        public int ino;
        public Marvellous(int ival)
        {
            ino = ival;
        }
        public int Power(int x,int y)
        {
            int ans = 0;

            for(int i=1;i<=y;i++)
            { 
                ans = x * x;
                
            }
            return ans;
        }
        public int SumFactor(int ino)
        {
            int sum = 0;
            int i = 0;
           
                for(i=1;i<=ino;i++)
                {
                    if(ino%i==0)
                    {
                        sum = sum + i;  
                    }
                }
            
            return sum;
        }
        public int CountDigit(int ino)
        {

            int idigit = 0;
            int i=0;
            while (ino != 0)
            {
                idigit = ino % 10;
                i++;
                ino = ino / 10;
            }
            return i;
        }
        public abstract Boolean CheckStrong();
        public abstract Boolean CheckArmstrong();
    }
}

