using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Marvellous_Calculator
{
    public class HistoryIO
    {
        public DateTime today;
        public HistoryIO()
        {
            today = DateTime.Now;            
        }

        public void UpdateHistory(string history)
        {
            if (history.Equals("0") || history.Equals("") || history.Equals(null))
            {
                return;
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("Marvellous.txt", true))
                {
                    sw.WriteLine(today + "  -=-  " + history + "\n");
                }
            }
        }

        public string PrintHistory()
        {
            return File.ReadAllText(@"Marvellous.txt");
        }

        public void ClearHistory()
        {
            File.WriteAllText(@"Marvellous.txt", String.Empty);
        }
    }
}
