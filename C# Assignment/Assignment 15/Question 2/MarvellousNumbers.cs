using System;

namespace MNumbers
{
    public class MarvellousNumbers
    {
        public int iNo;
        public MarvellousNumbers(int iNo)
        {
            this.iNo = iNo;
        }
        public void BinaryX()
        {
            string str = Convert.ToString(iNo, 2);
            Console.WriteLine("Binary is : "+ str);
        }

        public void OctalX()
        {
            string str = Convert.ToString(iNo, 8);
            Console.WriteLine("Ocatal is : "+ str);
        }

        public void HexX()
        {
            string str = Convert.ToString(iNo, 16);
            Console.WriteLine("Hexadecial is : "+ str);
        }
    }
}
