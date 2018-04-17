using System;
using System.Collections.Generic;
namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random myRnd = new Random();
            int[] array = new int[10];
            List<int> newArray = new List<int>();
            Randomaser randomaser = new Randomaser();

            Console.WriteLine("Исходный массив:");     
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRnd.Next(1, 10);
                Console.Write(array[i] + " ");
            }

            newArray = randomaser.FindEven(array);

            Console.WriteLine("\nРезультат:");
            for (int i = 0; i < newArray.Count; i++)
            {
                Console.Write(newArray[i] + " ");
            }

            newArray = randomaser.FindOdd(array);

            Console.WriteLine("\nРезультат:");
            for (int i = 0; i < newArray.Count; i++)
            {
                Console.Write(newArray[i] + " ");
            }

            Console.ReadKey();
        }

    }
}
