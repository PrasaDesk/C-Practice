using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    class EmployeeDetails
    {
        public string Name,Bloodgroup;
        public int Age;

        public EmployeeDetails()
        {

        }

        public void Accept()
        {
            Console.Write("Enter the Name : ");
            Name = Console.ReadLine();

            for (int i = 0; i < Name.Length; i++)
            {
                if (((Name[i] >= 'A') && (Name[i] <= 'Z')) || ((Name[i] >= 'a') && (Name[i] <= 'z')) || (Name[i] == ' '))
                {
                }
                else
                {
                    throw new InvalidNameException("Name Contain other than Characters."); ;
                }
            }

            Console.Write("Enter the Age : ");
            Age = Convert.ToInt32(Console.ReadLine());
            if (Age < 0)
            {
                throw new AgeInvalidException("Invalid Age (Negative Age)");
            }

            Console.Write("Enter the Blood Group : ");
            Bloodgroup = Console.ReadLine();
            if ((Bloodgroup.Equals("A")) || (Bloodgroup.Equals("O")) || (Bloodgroup.Equals("B")) || (Bloodgroup.Equals("AB")))
            {
            }
            else
            {
                throw new BloodGroupInvalidException("INVALID BLOOD Group BloodGroup should be A,B,O,AB : you Enter " + Bloodgroup);
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Name       : {0}", Name);
            Console.WriteLine("Age        : {0}", Age);
            Console.WriteLine("BloodGroup : {0}", Bloodgroup);
        }
    }
}
