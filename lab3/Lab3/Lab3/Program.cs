using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random myRnd = new Random();
            int[] array = new int[10];

            Randomaser randomaser = new Randomaser();

            Console.WriteLine("Исходный массив:");     
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRnd.Next(1, 10);
                Console.Write(array[i] + " ");
            }

            array = randomaser.random(array);

            Console.WriteLine("\nРезультат:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            

            Console.ReadKey();
        }

    }
}
