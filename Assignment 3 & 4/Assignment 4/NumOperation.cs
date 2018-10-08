using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNumTemplates
{
    class NumOperation : NumTemplates
    {
        public int iNo,iSum;
        public NumTemplates obj;
        public override void Accept()
        {
            Console.Write("Enter the Number : ");
            iNo = Convert.ToInt32(Console.ReadLine());
            if(iNo < 0)
            {
                iNo = -iNo;
            }
           
        }

        public override void Display()
        {
            bool bRet = true;
       
            Console.WriteLine("-----------------------------------------------------------------\n");
            Console.Write("Check Even Or NOT : \n");
            if (bRet == true)
            {
                Console.WriteLine("\nGiven Number is Even Number.\n");
            }
            else
            {
                Console.WriteLine("Given Number is Not a Even Number.\n");
            }
            Console.WriteLine("-----------------------------------------------------------------\n");

            Console.Write("Sumation of Factor is :  \n");

            Console.Write("\nAddition is : {0} \n",iSum);
            Console.WriteLine("-----------------------------------------------------------------\n");
        }

        public override bool ChkEven()
        {
            if((iNo % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void DisplayFactor()
        {
            int i = 0;
            Console.Write("Factor of {0} is : [ ", iNo);
            for(i = 1;i <= (iNo/2); i++)
            {
                if((iNo % i) == 0)
                {
                    Console.Write("{0}, ", i);
                }
            }
            Console.Write("{0} ]\n\n", iNo);
        }

        public override void SumFactor()
        {
            int i = 0;
            for(i = 1; i <= (iNo/2); i++)
            {
                if ((iNo % i) == 0)
                {
                    iSum = iSum + i;
                }
            }
            iSum = iSum + iNo;
        }
    }
}
