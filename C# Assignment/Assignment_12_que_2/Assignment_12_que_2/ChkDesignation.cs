using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12_que_2
{
    class ChkDesignation
    {
        public int Day, Year;
        public int Month;
        public void Accept()
        {
            try
            {
                Console.WriteLine("Enter Joining Date : ");
                Console.Write("Enter the Day : ");
                Day = Convert.ToInt32(Console.ReadLine());
                if (Day <= 0 || Day > 31)
                {
                    throw new InvalidAgeException("Day should be between 1 - 31 (INVALID INPUT)");
                }

                Console.Write("Enter the Month : ");
                Month = Convert.ToInt32(Console.ReadLine());
                if (Month <= 0 || Month > 12)
                {
                    throw new InvalidAgeException("Month Should be between 1 - 12 (INVALID INPUT)");
                }

                Console.Write("Enter the Year : ");
                Year = Convert.ToInt32(Console.ReadLine());
                if (Year > DateTime.Now.Year)
                {
                    throw new InvalidAgeException("Year should be Less than Current Year (INVALID INPUT)");
                }

            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e);
            }

        }

        public void ShowDesignation()
        {
            string[] mon = { "jan", "feb", "march", "april", "may", "june", "july", "aug", "sep", "oct", "nov", "dec" };

            DateTime Doj = Convert.ToDateTime(Day + mon[Month - 1] + Year);

            DateTime CurrentDate = DateTime.Now;
           

            TimeSpan ts = CurrentDate - Doj;
           

            DateTime Exp = DateTime.MinValue.AddDays(ts.Days);

            int Expirince = Exp.Year -1;
            
            Console.Write("Designation\n");
            if (Expirince < 1)
            {
                Console.WriteLine("Associate Software Engineer");
            }
            else if (Expirince >= 1 && Expirince < 3)
            {
                Console.WriteLine("Senior Software Engineer Level 1");
            }
            else if (Expirince >= 3 && Expirince < 5)
            {
                Console.WriteLine("Senior Software Engineer Level 2");
            }
            else
            {
                Console.WriteLine("Don't Know : Expirence is {0} Years",Expirince);
            }
        }
    }
}
