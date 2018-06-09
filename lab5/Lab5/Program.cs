//Вставить 0 после каждого элемента, большего по модулю среднего арифметического положительных элементов.
using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();//объявление и считывание. 
            string[] st = array.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int size = st.Length;
            int[] mas = new int[size];
            for (int i = 0; i < size; i++)
            {
                mas[i] = Convert.ToInt32(st[i]);
            }
            Count newArray = new Count(mas);
            foreach (int i in newArray.Addition())
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}