using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvellous_Calculator
{    
    public class NumberSystemLable
    {
        private int no;
        public NumberSystemLable(string s)
        {
            no = Convert.ToInt32(s);
        }
        public string BinaryX()
        {            
            return (Convert.ToString(no, 2));
        }

        public string HexX()
        {            
            return (Convert.ToString(no, 16));
        }

        public string OctalX()
        {
            return (Convert.ToString(no, 8));
        }
    }
}
