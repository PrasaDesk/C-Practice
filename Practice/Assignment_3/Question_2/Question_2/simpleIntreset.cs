using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class simpleIntreset
    {
        double Amt, Rate,Si;
        int time;

        public simpleIntreset(double x,double y,int a)
        {
            Amt = x;
            Rate = y;
            time = a;
            Si = 0;
        }

        public void simpleInt()
        {
            Si = (Amt * time * Rate) / 100;
        }

        public void display()
        {
            Console.WriteLine("Simpale interset is " + Si);
        }

    }
}
