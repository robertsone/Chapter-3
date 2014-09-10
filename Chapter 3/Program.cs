using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("What is your hourly pay: ");
            string pay = System.Console.ReadLine();
            double paynum = Convert.ToDouble(pay);
            if (paynum >= 5.65)
            {
                System.Console.WriteLine("That sounds good!");
            }
            else
            {
                System.Console.WriteLine("LIAR DONT YOU LIE TO ME!");
            }
        }
    }
}
