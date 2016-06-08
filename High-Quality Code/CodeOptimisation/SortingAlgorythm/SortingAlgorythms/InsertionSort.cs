using SortingAlgorythms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorythms.SortingAlgorythms
{
    internal class InsertionSort
    {
        /// <summary>
        /// Insertion Sorting Algorythm
        /// </summary>
        /// <param name="collection">
        /// random generated unsorted collection</param>
        /// <returns> sorted collection</returns>
        public static List<int> InsertionSortAlgorythm(List<int> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection can not be null!");
            }

            Utils.StopWatch.Start();

            for (int i = 1; i < collection.Count; i++)
            {
                int element = collection[i];
                int left = 0;
                int right = i - 1;

                while (left <= right)
                {
                    int middle = (left + right) / 2;

                    if (element.CompareTo(collection[middle]) < 0)
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

                for (int j = i - 1; j >= left; j--)
                {
                    collection[j + 1] = collection[j];
                }

                collection[left] = element;
            }
            Utils.StopWatch.Stop();
            Utils.ElepsedTime = Utils.StopWatch.Elapsed;

            return collection;
        }
    }
}