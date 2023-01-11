using System;

namespace _11._01._23
{
    class Program
    {
        static void Main(string[] args)
        {
            // var numberTask = new NumberTask();
            // int number = int.Parse(Console.ReadLine());

            // numberTask.SumDigit(number);

            //Console.WriteLine(numberTask.SumDigit(number));


            var swapMaxandMin = ArrayTask.EnterswapMaxndMin ();
            ArrayTask.Print(swapMaxandMin);
            ArrayTask.SwapMaxandMin(swapMaxandMin);
            ArrayTask.Print(swapMaxandMin);
        }       
    }
}
