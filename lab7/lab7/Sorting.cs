using System;

namespace lab7
{
    class Sorting
    {
        private int[,] array;
        public Sorting(int[,] beginArray)
        {
            array = beginArray;
        }

        private int FindingIndexOfNegative()
        {
            int maxOfNegative = 0;
            int indexOfNegative = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    if (array[i, j] < 0 && Math.Abs(array[i, j]) > maxOfNegative)
                    {
                        indexOfNegative = j;
                        maxOfNegative = array[i, j];
                    }
                }
            }
            return indexOfNegative;
        }

        private int FindingIndexOfPositive()
        {
            int minOfPositive = array[0, 0];
            int indexOfPositive = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i, j] > 0 && array[i, j] < minOfPositive)
                    {
                        indexOfPositive = j;
                        minOfPositive = array[i, j];
                    }
                }
            }
            return indexOfPositive;
        }

        public int[,] Reshuffle()
        {
            int indexofPositive = FindingIndexOfPositive();
            int indexOfNegative = FindingIndexOfNegative();
            int temp = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                temp = array[i, indexofPositive];
                array[i, indexofPositive] = array[i, indexOfNegative];
                array[i, indexOfNegative] = temp;
            }
            return array;
        }
    }
}
