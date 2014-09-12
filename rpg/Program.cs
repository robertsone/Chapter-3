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
            string Player_Class = "";
            string Responce = "";
            List<String> Inventory = new List<String>();//0: weapon,1:armor
            {
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
                Inventory.Add("none");
            }
            while (true)
            {



                if (location == "Startup")
                {
                    System.Console.WriteLine(Name + ", What class do you want?\nRouge\tMage\tKnight");
                    Player_Class = System.Console.ReadLine().ToLower();
                    if (Player_Class != "rouge" && Player_Class != "mage" && Player_Class != "knight\n")
                        System.Console.WriteLine("Sorry this is not a class.\n");
                    else
                        location = "Weapon select";
                }



                if (location == "Weapon select")
                {
                    if (Player_Class == "mage")
                    {
                        System.Console.WriteLine("Mages use staffs and wands, you may use other weapons,but they are less effective\nYou start with a wand.\n");
                        Inventory[0]="wand";
                    }
                    if (Player_Class == "knight")
                    {
                        System.Console.WriteLine("Knights use swords, shields, and speers, you may use other weapons,but they are less effective\n You start with a sword.\n");
                        Inventory[0] = "sword";
                    }
                    if (Player_Class == "rouge")
                    {
                        System.Console.WriteLine("Rouges use knives, poisons, and daggers, you may use other weapons,but they are less effective\nYou start with a knife.\n");
                        Inventory[0] = "knife";
                    }
                    location = "Tutorial";
                }


                if (location == "Tutorial")
                    System.Console.WriteLine("This is a text based adventure-rpg game, You may use the following commands:\ninventory\nhealth\nexp\nmana\nOr anything else told latter\n"); location = "Home";

                if (location == "Home")
                {
                    System.Console.WriteLine("You are in youre house");
                    Responce = System.Console.ReadLine();
                }




            }
        }
    }
}
