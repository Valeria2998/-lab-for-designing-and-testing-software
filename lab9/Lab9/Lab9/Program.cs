//Упорядочить элементы в матрице по убыванию(cправа налево, снизу ввех)
using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] beginArray = new int[3, 3] { { 9, 6, 2 }, { 4, 3, 5 }, { 1, 7, 8 } };
            Sorting newArray = new Sorting(beginArray);
            newArray.SortingNewArray();
            int[,] sorted = newArray.getArray();
            for (int i = 0; i < sorted.GetLength(0); i++)
            {
                for (int j = 0; j < sorted.GetLength(1); j++)
                {
                    Console.Write(sorted[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}