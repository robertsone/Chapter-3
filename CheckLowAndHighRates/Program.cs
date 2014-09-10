using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRates
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("What is your hourly pay: ");
            string pay = System.Console.ReadLine();
            double paynum = Convert.ToDouble(pay);
            if (paynum >= 5.65 && paynum <= 49.99)
            {
                System.Console.WriteLine("That sounds good!");

            }
            else
            {
                System.Console.WriteLine("Wow, you liar!");
            }
        }
    }
}
