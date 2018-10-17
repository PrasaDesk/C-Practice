using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12_que_2
{
    class ChkAge
    {
        public int Day, Year;
        public int Month;
        public void Accept()
        {
            try
            {
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
                if( Year > DateTime.Now.Year)
                {
                    throw new InvalidAgeException("Year should be Less than Current Year (INVALID INPUT)");
                }

            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e);
            }
            
        }

        public void CalculateAge()
        {
            string[] mon = { "jan", "feb", "march","april","may","june","july","aug","sep","oct","nov","dec" };
            
            DateTime Dob = Convert.ToDateTime(Day + mon[Month-1] + Year);

            DateTime CurrentDate = DateTime.Now;
           
            TimeSpan ts = CurrentDate - Dob;
            
            DateTime Age = DateTime.MinValue.AddDays(ts.Days);
            //Console.WriteLine(Age);

            Console.WriteLine(string.Format("Your Age is : {0} Years, {1} Month, {2} Days", Age.Year - 1, Age.Month - 1, Age.Day - 1));
        }
    }
}
