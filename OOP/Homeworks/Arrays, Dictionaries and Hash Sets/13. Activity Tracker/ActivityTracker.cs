using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Activity_Tracker
{
    class ActivityTracker
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, SortedDictionary<string, int>> activity = new SortedDictionary<int, SortedDictionary<string, int>>();

            int length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                string[] input = Console.ReadLine().Split();

                string[] date = input[0].Split(new char[] { '/' });
                int month = int.Parse(date[1]);

                string name = input[1];
                int distance = int.Parse(input[2]);

                if (!activity.ContainsKey(month))
                {
                    activity[month] = new SortedDictionary<string, int>();
                }

                if (activity[month].ContainsKey(name))
                {
                    activity[month][name] += distance;
                }
                else
                {
                    activity[month].Add(name, distance);
                }

            }

            foreach (var item in activity)
            {
                Console.Write("{0}: ", item.Key);

                foreach (var subpair in item.Value)
                {
                    if (subpair.Key.Equals(item.Value.Keys.Last()))
                    {
                        Console.Write("{0}({1})", subpair.Key, subpair.Value);
                    }
                    else
                    {
                        Console.Write("{0}({1}), ", subpair.Key, subpair.Value);
                    }
                }
                Console.WriteLine();
            }

             


        }
    }
}
