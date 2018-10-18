using System;

using CheckNumber;
using CheckNumber.NumberOpration;
using ArrayOperation;
class Demo
{
  public static void Main(String[] argv)
  {
    Console.WriteLine("Hello Prasad");

    Console.WriteLine("Enter First Number : ");
    int x = Convert.ToInt32(Console.ReadLine());
    ChkNumber cn = new ChkNumber();
    bool bRet = cn.IsPrime(x);
    if(bRet == true)
    {
      Console.WriteLine("{0} is Prime Number",x);
    }
    else
    {
      Console.WriteLine("{0} is Not a Prime Number",x);
    }

    bRet = cn.IsPerfect(x);
    if(bRet == true)
    {
      Console.WriteLine("{0} is Perfect Number",x);
    }
    else
    {
      Console.WriteLine("{0} is Not a Perfect Number",x);
    }

    NumberOp no = new NumberOp();
    no.IsOdd(x);
    no.IsEven(x);

    Console.WriteLine("Enter Size of Array : ");
    x = Convert.ToInt32(Console.ReadLine());
    OpArray oa = new OpArray(x);
    oa.DisplayArr();

  }
}
