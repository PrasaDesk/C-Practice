using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class WordNumber
    {
        public int iNo;
        public String[] str;

        public WordNumber(int no)
        {
            if(no < 0)
            {
                no = -no;
            }
            iNo = no;

            str = new String[10];
            str = { "Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine"};
        }
            
        public void displayNumToword()
        {
            while(iNo != 0)
            {
                Console.Write(str[iNo % 10]);
                iNo = iNo / 10;
            }
        }
    }
}
