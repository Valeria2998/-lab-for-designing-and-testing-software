// Добавить строку, содержащую сумму положительных после каждой строки с отрицательным числом
using System;
using System.Collections.Generic;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> list = new List<List<int>>(); //инициализация
            list.Add(new List<int>() { 3, 2, 1});//добавление новой строки
            list.Add(new List<int>() { 5, -6, 7});
            list.Add(new List<int>() { 3, 2, -3,});
            AddToAnArray newStroke = new AddToAnArray();
            list.Add(newStroke.Add(list));
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    Console.Write(list[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
