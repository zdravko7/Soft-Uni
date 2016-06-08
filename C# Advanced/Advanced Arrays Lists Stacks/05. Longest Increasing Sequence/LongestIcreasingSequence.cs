using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Longest_Increasing_Sequence
{
    class LongestIcreasingSequence
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(p => int.Parse(p)).ToArray();

            List<int> Increasing = new List<int>();
            Increasing.Add(numbers[0]);

            List<int> LongestIncreasing = new List<int>();

            for (int i = 1; i < numbers.Length; i++)
            {
                try
                {
                    if (numbers[i] > numbers[i - 1])
                    {
                        Increasing.Add(numbers[i]);
                    }

                    else
                    {

                        if (Increasing.Count > LongestIncreasing.Count)
                        {
                            LongestIncreasing.Clear();
                            CopyList(Increasing, LongestIncreasing);
                            Increasing.Clear();
                        }
                        else
                        {
                            Increasing.Clear();
                            Increasing.Add(numbers[i]);
                        }
                    }

                    if (Increasing.Count > LongestIncreasing.Count && (numbers[i] > numbers[i - 1]) && (i == numbers.Length - 1))
                    {
                        LongestIncreasing.Clear();
                        CopyList(Increasing, LongestIncreasing);
                        Increasing.Clear();
                    }
                }
                catch (Exception) { continue; }
            }


            foreach (var item in LongestIncreasing)
            {
                Console.Write(item + " ");
            }
        }

        public static List<int> CopyList(List<int> oldList, List<int> newList)
        {
            for (int i = 0; i < oldList.Count; i++)
            {
                newList.Add(oldList[i]);
            }
            return newList;
        }
    }

    
}
