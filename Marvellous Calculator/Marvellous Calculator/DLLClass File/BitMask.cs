using System;
using System.Collections;


namespace Marvellous_Calculator
{
    public class BitMask
    {
        public BitArray bitmask;

        public BitMask()
        {
            bitmask = new BitArray(32);                      
        }      

        public BitArray SetMask(int no)
        {
            int[] a = { no };
            bitmask = new BitArray(a);
            return bitmask;
        }

        public BitArray ToggleBit(int pos)
        {
            BitArray mask = new BitArray(32);
            int[] imask = { 0 };

            mask = new BitArray(imask);
            mask.Set(pos,true);

            bitmask.Xor(mask);
            return bitmask;    
        }

        
    }
}
