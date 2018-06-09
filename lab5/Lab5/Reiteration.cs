using System;
using System.Collections.Generic;

namespace Lab5
{
    class Count
    {
        private int[] array;
        public Count(int[] beginArray)
        {
            array = beginArray;
        }

        private int NumberOfPositive()
        {
            int value = 0;
            foreach (int i in array)
            {
                if (i > 0)
                    value++;
            }
            return value;
        }

        private double PositiveAverage()
        {
            int averageOfNumbers = 0;
            int sumOfPositiveNumbers = 0;
            foreach (int i in array)
            {
                if (i > 0)
                {
                    sumOfPositiveNumbers += i;
                }
            }
            averageOfNumbers = sumOfPositiveNumbers / NumberOfPositive();
            return averageOfNumbers;
        }



        public List<int> Addition()
        {
            List<int> newArray = new List<int>();
            foreach (int i in array)
            {
                newArray.Add(i);
                if (Math.Abs(i) > PositiveAverage())
                {
                    newArray.Insert(newArray.IndexOf(i) + 1, 0);
                }
            }
            return newArray;
        }

    }
}