using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int Adddel();
delegate int Subdel();
delegate int Multdel();
delegate int Divdel();

delegate int DelArr();

delegate int DelArithmatic();

namespace Assignment_5
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Delegates/////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\nSingale Delegates\n");
            int iNo1 = 0, iNo2 = 0; ;
            Console.Write("Enter Two Numbers : ");
            iNo1 = Convert.ToInt32(Console.ReadLine());
            iNo2 = Convert.ToInt32(Console.ReadLine());

            Artithmatic obj = new Artithmatic(iNo1,iNo2);

            Adddel objA = obj.Add;
            Console.WriteLine("Addition : {0}", objA());

            Subdel objS = new Subdel(obj.Sub);
            Console.WriteLine("Substraction : {0}", objS());

            Multdel objM = new Multdel(obj.Mult);
            Console.WriteLine("Multiplication : {0}", objM());

            Divdel objD = new Divdel(obj.Div);
            Console.WriteLine("Division : {0}", objD());

            //Array of delegates/////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\nArray of Delegates\n");
            DelArr[] ArrDel = new DelArr[4];
            ArrDel[0] = new DelArr(obj.Add);
            ArrDel[1] = new DelArr(obj.Sub);
            ArrDel[2] = new DelArr(obj.Mult);
            ArrDel[3] = new DelArr(obj.Div);

            Console.WriteLine("Addition : " + ArrDel[0]());
            Console.WriteLine("Substraction : "+ ArrDel[1]());
            Console.WriteLine("Multiplication : "+ ArrDel[2]());
            Console.WriteLine("Division : "+ ArrDel[3]());

            //Multicast Delegates///////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\nMultiCast Delegates\n");
            DelArithmatic MultiCast ;
            
            MultiCast = new DelArithmatic(obj.Add);
            MultiCast += new DelArithmatic(obj.Sub);
            MultiCast += new DelArithmatic(obj.Mult);
            MultiCast += new DelArithmatic(obj.Div);
            
            Console.WriteLine("Division is "+ MultiCast());

            MultiCast -= new DelArithmatic(obj.Div);
            Console.WriteLine("Multiplication is "+ MultiCast());

            MultiCast -= new DelArithmatic(obj.Mult);
            Console.WriteLine("Substraction is "+ MultiCast());

            MultiCast -= new DelArithmatic(obj.Sub);
            Console.WriteLine("Addition is "+ MultiCast());

            MultiCast -= new DelArithmatic(obj.Add);
                        
        }
    }
}
