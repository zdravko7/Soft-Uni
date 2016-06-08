﻿using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorythms.SortingAlgorythms
{
    class QuickSort
    {

        /// <summary>
        /// Quick Sort Algorythm
        /// </summary>
        /// <param name="collection">unsorted collection</param>
        /// <param name="leftIndex">start index of collection to be sorted</param>
        /// <param name="rightIndex">end index of collection to be sorted</param>
        /// <returns> sorted collection</returns>
        public static List<int> QuickSortAlgorythm(List<int> collection, int leftIndex, int rightIndex)
        {
            if (collection == null)
            {
                throw new ArgumentOutOfRangeException("Collection can not be null!");
            }

            if (leftIndex >= rightIndex)
            {
                return collection;
            }

            int leftPointer = leftIndex;
            int rightPointer = rightIndex;
            var pivot = collection[(leftIndex + rightIndex) / 2];

            Utils.StopWatch.Start();

            while (leftPointer <= rightPointer)
            {
                while (collection[leftPointer].CompareTo(pivot) < 0)
                {
                    leftPointer++;
                }

                while (collection[rightPointer].CompareTo(pivot) > 0)
                {
                    rightPointer--;
                }

                if (leftPointer <= rightPointer)
                {
                    int swapPosition = collection[leftPointer];
                    collection[leftPointer] = collection[rightPointer];
                    collection[rightPointer] = swapPosition;

                    leftPointer++;
                    rightPointer--;
                }

                if (leftPointer < rightIndex)
                {
                    QuickSortAlgorythm(collection, leftPointer, rightIndex);
                }

                if (leftIndex < rightPointer)
                {
                    QuickSortAlgorythm(collection, leftIndex, rightPointer);
                }
            }

            Utils.StopWatch.Stop();
            Utils.ElepsedTime = Utils.StopWatch.Elapsed;

            return collection;
        }
    }
}