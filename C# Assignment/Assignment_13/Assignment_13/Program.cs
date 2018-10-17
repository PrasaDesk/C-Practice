using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList bl = new BookList();
            bool ter = true;
            string name, author;
            Console.WriteLine("0.MENU\n1.acccept new book\t2.Display Book details\n3.Price Range Books\t4.Maximum Price Book\n5.Minimum Price Book\t6.Author Books\n7.Delete Book\t\t8.Display Book who's copies is less than 5\n9.Total cost books\t10.EXIT");
            while (ter == true)
            {
                
                Console.WriteLine("==================================================");
                Console.WriteLine("For MENU Enter Choice 0");              
                Console.Write("==> Enter choice : ");
                int iChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------");
                switch (iChoice)
                    {
                    case 0:
                        Console.WriteLine("0.MENU\n1.acccept new book\t2.Display Book details\n3.Price Range Books\t4.Maximum Price Book\n5.Minimum Price Book\t6.Author Books\n7.Delete Book\t\t8.Display Book who's copies is less than 5\n9.Total cost books\t10.EXIT");
                        break;
                    case 1:
                            bl.AcceptBook();                                                        
                            break;                        
                    case 2:
                        Console.Write("Enter the Book Name : ");
                        name = Console.ReadLine();

                        bl.BookDetails(name);
                        break;
                    case 3:
                        Console.Write("Enter the Mininum Price : ");
                        int Min = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Maximum Price : ");
                        int Max = Convert.ToInt32(Console.ReadLine());
                        bl.DisplayRangeBook(Min, Max);
                        break;
                    case 4:
                        bl.MaxPriceBook();
                        break;

                    case 5:
                        bl.MinPriceBook();
                        break;

                    case 6:
                        Console.Write("Enter the Book Author Name : ");
                        author = Console.ReadLine();
                        bl.AuthorsBook(author);
                        break;
                    case 7:
                        Console.Write("Enter the Book Author Name : ");
                        name = Console.ReadLine();
                        bl.DeleteBook(name);
                        break;
                    case 8:
                        bl.LessCopyBooks();
                        break;

                    case 9:
                        int totalcost = bl.TotalCost();
                        Console.WriteLine("Total Cost of all Books Avaliable is {0}", totalcost);
                        break;
                    case 10:
                        Console.WriteLine("E  X  I  T");
                        ter = false;
                        break;
                    default : Console.WriteLine("INVALID INPUT");
                            break;

                    }
                
            }
        }
    }
}
