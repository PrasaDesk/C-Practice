using System;
using arithmatic;

public class Program
{
  public static void Main(String[] argv)
  {
    int iNo1 = 0,iNo2 = 0,iRet = 0;
    Console.WriteLine("Enter the Number1 : ");
    iNo1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the Number2 : ");
    iNo2 = Convert.ToInt32(Console.ReadLine());
    ArithmaticOp ao = new ArithmaticOp();
    int a = 0;
    Console.WriteLine("1: AddX\n2: SubX\n3: MultX\n4: DivX\nEnter the Choice : ");
    a = Convert.ToInt32(Console.ReadLine());
    switch(a)
    {
      case 1:
            iRet = ao.AddX(iNo1,iNo2);
            Console.WriteLine("Addition is : {0}",iRet);
            break;

      case 2:
            iRet = ao.SubX(iNo1,iNo2);
            Console.WriteLine("Substraction is : {0}",iRet);
            break;

      case 3:
            iRet = ao.MultX(iNo1,iNo2);
            Console.WriteLine("Multiplication is : {0}",iRet);
            break;

      case 4:
            iRet = ao.DivX(iNo1,iNo2);
            Console.WriteLine("Division is : {0}",iRet);
            break;
    }
  }
}
