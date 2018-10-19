using System;

namespace arithmatic
{
  public class ArithmaticOp
  {
      public int AddX(int iNo1,int iNo2)
      {
        int ans = iNo1 + iNo2;
        return ans;
      }

      public int SubX(int iNo1,int iNo2)
      {
        int ans = iNo1 - iNo2;
        return ans;
      }

      public int MultX(int iNo1,int  iNo2)
      {
        int ans = iNo1 * iNo2;
        return ans;
      }

      public int DivX(int iNo1,int iNo2)
      {
        int ans = 0;
        try
        {
          ans = iNo1 / iNo2;
        }
        catch(Exception e)
        {
          Console.WriteLine(e);
        }
        return ans;
      }
  }
}
