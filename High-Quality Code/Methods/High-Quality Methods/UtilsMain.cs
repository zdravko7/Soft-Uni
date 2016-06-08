﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighQualityMethods.Utils;

namespace HighQualityMethods
{
    class UtilsMain
    {
        static void Main(string[] args)
        {
            //Triangle sides and area calculation
            double pointA = 4;
            double pointB = 3;
            double pointC = 5;

            double area = PolygonUtil.CalculateTriangleArea(pointA, pointB, pointC);
            Console.WriteLine("Triangle area is - {0}", area);

            //Points coordinate and distance calculation
            double pointX1 = 3;
            double pointY1 = -1;
            double pointX2 = 3;
            double pointY2 = 2.5;

            double distance = PolygonUtil.CalculatePointsDistance(pointX1, pointY1, pointX2, pointY2);
            Console.WriteLine("Distance between points is: {0}", distance);

            //Boolean calculation for points
            bool arePointsHorisontal = PolygonUtil.ArePointsHorizontal(pointY1, pointY2);
            bool arePointsVertical = PolygonUtil.ArePointsVertical(pointX1, pointX2);
            Console.WriteLine("Are points horizontal? - {0}", arePointsHorisontal);
            Console.WriteLine("Are points vertical? - {0}", arePointsVertical);
            Console.WriteLine(Environment.NewLine);

            //Represent digit as string
            string number = NumberUtil.GetDigitName(5);
            Console.WriteLine("Digit to number:  {0}", number);

            //Calculate max element in collection
            int[] numberCollection = { 5, -1, 3, 2, 14, 2, 3 };
            int maxElement = NumberUtil.FindMaxNumber(numberCollection);
            Console.WriteLine("Max element in collection is: {0}", maxElement);

            //Print different formating
            Console.WriteLine("Fixed point formating");
            NumberUtil.PrintNumberWithFixedPoint(1.3);
            Console.WriteLine("Percent formating");
            NumberUtil.PrintNumberAsPercent(0.75);
            Console.WriteLine("Right alignment formating");
            NumberUtil.PrintNumberRightAlignment(2.30);
            Console.WriteLine(Environment.NewLine);


        }
    }
}