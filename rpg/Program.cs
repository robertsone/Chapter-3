using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            string location = "Startup";

            System.Console.Write("Name Your Player:");
            string Name = System.Console.ReadLine();

            while (true)
            {


                if (location == "Startup")
                {
                    System.Console.WriteLine(Name + ", What class do you want?\nRouge\tMage\tKnight");
                    string Player_Class = System.Console.ReadLine();
                    if (Player_Class == "Rouge") ;
                    else if (Player_Class == "Mage") ;
                    else if (Player_Class == "Knight") ;
                    else System.Console.WriteLine("Sorry, thats not a class");
                }


            }
        }
    }
}
