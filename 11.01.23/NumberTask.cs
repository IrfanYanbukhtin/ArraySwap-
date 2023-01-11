using System;
using System.Collections.Generic;
using System.Text;

namespace _11._01._23
{
    class NumberTask
    {
        internal int SumDigit(int number)
        {
           int i;
           int SumDigit = 0;
            while (number != 0)
            {
                i = number % 10;
                number /= 10;
                SumDigit += i;
            }
          
           Console.WriteLine(SumDigit);
             return SumDigit;
        }          
    }
}
