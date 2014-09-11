using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("What is your hourly wage?");int pay = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("How many hours weekly do you spend in a pointless cubicle"); int hours = Convert.ToInt32(System.Console.ReadLine());
            double totalpay = pay * hours;

            if (totalpay >= 300.01) System.Console.WriteLine("\nGross pay\t\tWithhold Percent\t\tTotal\n\n" + totalpay + "\t\t\t%12\t\t\t\t"+(totalpay-(totalpay*0.12)));
            else System.Console.WriteLine("\nGross pay\t\tWithhold Percent\t\tTotal\n\n" + totalpay + "\t\t\t%10\t\t\t\t" + (totalpay - (totalpay * 0.10)));
                


        }
    }
}
