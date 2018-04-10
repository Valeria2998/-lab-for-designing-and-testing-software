using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 10, 7, 8, 4, 2, 4, 1, 1, 3 };
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Swapper swapper = new Swapper();
            int[] result = swapper.Swap(array);
          
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        
    }
}
