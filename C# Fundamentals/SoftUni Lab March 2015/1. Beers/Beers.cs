using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Beers
{
    static void Main(string[] args)
    {
        string input = "";
        string[] beers = new string[2];
        int result = 0;

        while(true)
        {
            input = Console.ReadLine();

            if (input == "End")
                break;

            beers = input.Split();

            if (beers[1] == "beers")
            {
                result += int.Parse(beers[0]);

            }
            else if (beers[1] == "stacks")
            {
                int num = int.Parse(beers[0]);
                result += num*20;
            }

        }

        int stacks = 0;

        while (result > 19)
        {
            result -= 20;
            stacks++;
        }

        Console.WriteLine("{0} stacks + {1} beers", stacks, result);

    }
}
