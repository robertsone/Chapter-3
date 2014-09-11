using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            int unit;
            System.Console.Write("What wood type do you want?\n\nCom\tName\t\tPrice\n\n[p]\tPine\t\t$100\n[o]\tOak\t\t$225\n[m]\tMahogany\t$310\n");
            string response = Console.ReadLine().ToLower();
            System.Console.WriteLine("How many units of wood?");
            string amount = Console.ReadLine(); unit = Convert.ToInt32(amount);
            if (unit >0)
            {
                if (response == "p")
                {
                    System.Console.WriteLine("You have bought " + unit + " Pine for $" + unit * 100);
                }
                else if (response == "o")
                {
                    System.Console.WriteLine("You have bought " + unit + " Oak for $" + unit * 225);
                }

                else if (response == "m")
                {
                    System.Console.WriteLine("You have bought " + unit + " Mahogany for $" + unit*310);
                }
                else
                {
                    System.Console.WriteLine("That isn't a type of wood, reopen the program and try typing the lowercase letter p, o, or m.");
                }
            }
            

            



        }
    }
}
