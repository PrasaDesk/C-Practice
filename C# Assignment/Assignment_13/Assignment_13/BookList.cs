using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13
{
    class BookList
    {
        private string bname, bauthor, bpublication;
        private int bprice, bcopies;
        private List<Books> blist = new List<Books>();

        public void AcceptBook()
        {
            Console.Write("Enter the Book Name : ");
            bname = Console.ReadLine();
            Console.Write("Enter the Book Autor Name : ");
            bauthor = Console.ReadLine();
            Console.Write("Enter the Book Publication Name : ");
            bpublication = Console.ReadLine();
            Console.Write("Enter the Book Price : ");
            bprice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Book No Copies : ");
            bcopies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("_____________________________________________");

            blist.Add(new Books(bname, bauthor, bpublication, bprice, bcopies));
        }

        public void DisplayRangeBook(int start, int end)
        {
            for (int i = 0; i < blist.Count; i++)
            {
                if(blist[i].bprice >= start && blist[i].bprice <= end)
                {
                    Console.WriteLine("Book name : {0}", blist[i].bname);
                }
            }
        }

        public void BookDetails(string tname)
        {
            int i = 0;
            
            for (i = 0; i < blist.Count; i++)
            {
                if (blist[i].bname.Equals(tname))
                {
                    blist[i].Display();
                    break;
                }
            }
            if (i == blist.Count)
            {
                Console.WriteLine("No Such Book is Avaliable.");
            }
        } 

        public void MaxPriceBook()
        {
            int max = int.MinValue;
            int index = 0;
            for (int i = 0; i < blist.Count; i++)
            {
                if (max < blist[i].bprice)
                {
                    max = blist[i].bprice;
                    index = i;
                }
            }
            Console.WriteLine("Book Name  : {0}", blist[index].bname);
            Console.WriteLine("Book Price : {0}", blist[index].bprice);
        }

        public void MinPriceBook()
        {
            int min = int.MaxValue;
            int index = 0;
            for (int i = 0; i < blist.Count; i++)
            {
                if (min > blist[i].bprice)
                {
                    min = blist[i].bprice;
                    index = i;
                }
            }
            Console.WriteLine("Book Name  : {0}", blist[index].bname);
            Console.WriteLine("Book Price : {0}", blist[index].bprice);
        }

        public void AuthorsBook(string tauthor)
        {
            for (int i = 0; i < blist.Count; i++)
            {
                if (blist[i].bauthor.Equals(tauthor))
                {
                    Console.WriteLine("Book Name : {0}", blist[i].bname);
                }
            }
        }

        public void DeleteBook(string tname)
        {
            int i = 0;
            for (i = 0; i < blist.Count; i++)
            {
                if (blist[i].bname.Equals(tname))
                {
                    blist.RemoveAt(i);
                    Console.WriteLine("Book Succesfully Deleted....!!!!");
                    break;
                }
            }
            if(i == blist.Count)
            {
                Console.WriteLine("Not Such book to Delete");
            }
        }

        public void LessCopyBooks()
        {
            int f = 0;
            for (int i = 0; i < blist.Count; i++)
            {
                if (blist[i].bcopies < 5)
                {
                    f = 1;
                    Console.WriteLine("Book Name : {0}", blist[i].bname);
                }
            }
            if (f == 0)
            {
                Console.WriteLine("There is no Book who's copy is less than 5");
            }
        }

        public int TotalCost()
        {
            int cost = 0;
            for (int i = 0; i < blist.Count; i++)
            {
                cost = cost + blist[i].bcopies * blist[i].bprice;
            }
            return cost;
        }
    }
}
