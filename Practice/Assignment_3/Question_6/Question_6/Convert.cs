using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
{
    class Convert
    {
        public int iNo,idig;
        
        public Convert(int no)
        {
            iNo = no;
            
        }

        public void toBinary()
        {
            while(iNo >= 1)
            {
                idig = iNo % 2;
                iNo = iNo / 2;
                Console.Write(idig + " ");
      
            }
            
        }
    }
}
