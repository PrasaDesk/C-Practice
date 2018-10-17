using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13
{
    class Books
    {
        public string bname, bauthor, bpublication;
        public int bprice, bcopies;
        public Books(string name,string author,string publication,int price,int copies)
        {
            bname = name;
            bauthor = author;
            bpublication = publication;
            bprice = price;
            bcopies = copies;
        }

        public void Display()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("Book Name        : {0}", bname);
            Console.WriteLine("Book Author      : {0}", bauthor);
            Console.WriteLine("Book Publication : {0}", bpublication);
            Console.WriteLine("Book Price       : {0}", bprice);
            Console.WriteLine("Book Copies      : {0}", bcopies);
            Console.WriteLine("*****************************************");
        }
    }
}
