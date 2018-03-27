using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitsAnalyser digitsAnalyser = new DigitsAnalyser();
            bool IsCorrect = false;
            string s = "";
            while (!IsCorrect)
            {

                Console.WriteLine("Введите четырехзначное число");
                s = Console.ReadLine();
                IsCorrect = true;

                for (int i = 0; i < s.Length; i++)
                {
                    if (!char.IsDigit(s[i]))
                    {
                        IsCorrect = false;
                    }
                }
                if (s.Length != 4)
                {
                    IsCorrect = false;
                }
            }

            int k = Convert.ToInt32(s);
            int summa = 0;
            int multiplication = 1;


            summa = digitsAnalyser.SplitNumber1(k);
            multiplication = digitsAnalyser.SplitNumber2(k);

            Console.WriteLine("Сумма цифр этого числа равна {0}, произведение цифр этого числа равно {1}", summa, multiplication);

            Console.ReadLine();
        }
    }
}
