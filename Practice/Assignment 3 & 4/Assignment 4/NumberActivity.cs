using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNumTemplates
{
    class NumberActivity : NumOperation
    {
        //factorial 
        //chk prime
        //chk perfect
        public int iNo, iFact;
        public NumOperation NP;
       // public NumTemplates NT;
        public NumberActivity()
        {
            NP = new NumOperation();
            NP.Accept();
            iNo = NP.iNo;
        }

        public NumberActivity(NumOperation obj)
        {
            iNo = obj.iNo;
            iFact = 1;
        }

        public void Factorial()
        {
            int i = 0;
            for(i = 1;i <= iNo; i++)
            {
                iFact = iFact * i;
            }
        }

        public bool ChkPrime()
        {
            int i = 0,chk = 0;
            for(i = 2; i <= iNo/2; i++)
            {
                if((iNo % i) == 0)
                {
                    chk = 1;
                    break;
                }
            }
            if (chk == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChkPerfect()
        {
            int sum = 0, i = 0;
            for (i = 1; i <= iNo / 2; i++)
            {
                if ((iNo % i) == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == iNo)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Display()
        {
            Console.WriteLine("Factorial of Givern Number is : {0}\n\n", iFact);
        }

    }
}
