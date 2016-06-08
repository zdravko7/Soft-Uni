﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorythms.SortingAlgorythms
{
    internal class SelectionSort
    {
        /// <summary>
        /// Selection Srting Algorythm
        /// </summary>
        /// <param name="collection">random generated unsorted collection</param>
        /// <returns> sorted collection</returns>
        public static List<int> SelectionSortAlgorythm(List<int> collection)
        {
            if (collection == null)
            {
                throw new ArgumentOutOfRangeException("Collection can not be null!");
            }

            Utils.StopWatch.Start();

            for (int i = 0; i < collection.Count - 1; i++)
            {
                int minPosition = i;

                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j] < collection[minPosition])
                    {
                        minPosition = j;
                    }
                }

                if (minPosition != i)
                {
                    int swapPosition = collection[i];
                    collection[i] = collection[minPosition];
                    collection[minPosition] = swapPosition;
                }
            }

            Utils.StopWatch.Stop();
            Utils.ElepsedTime = Utils.StopWatch.Elapsed;
            return collection;
        }
    }
}