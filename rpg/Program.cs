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
            List<List<string>> Map = new List<List<string>>();
            List<String> col = new List<String>();
            int colNUM = 0;
            int rowNUM = 0;
            while (true)
            {
                col.Add("_");
                colNUM += 1;
                if (colNUM >= 20)
                {
                    colNUM = 0;
                    rowNUM += 1;
                    Map.Add(col);
                    if (rowNUM >= 70)
                        break;
                }

            }
            int location = 0;
            int location2 = 0;
            while (true)
            {



                for (int num1 = 0; num1 <= 48; num1++)
                {
                    string row = "";
                    for (int num2 = 0; num2 <= 48; num2++)
                    {
                        row += (Map[num1][num2]);
                    }
                    System.Console.WriteLine(row);
                }

                location += 1;
                if (location >= 4000)
                {
                    location = 0;
                    location2 += 1;
                    Map[location2 - 1][25] = "_";
                    Map[location2][25] = "@";
                }





            }



        }
    }
}
