// Поменять местами столбцы, содержащие максимальный по модулю отрицательный элемент и минимальный положительный
using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] beginArray = new int[,] { { 1, 4, 7 }, { 2, -5, 8 }, { 3, 6, 9 } };
            Sorting Array = new Sorting(beginArray);
            int[,] newArray = Array.Reshuffle();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(newArray[i, j].ToString().PadLeft(3) + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
