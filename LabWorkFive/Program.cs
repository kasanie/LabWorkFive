using System;

namespace LabWorkFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Введите число:");
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка. Введите число:");
                    continue;
                }
            }
            var prime = PrimeOrNot(input);
            if (prime)
            {
                Console.WriteLine("Число " + input + " простое");
            }
            else
            {
                Console.WriteLine("Число " + input + " не является простым");
            }
            Console.WriteLine("Вывод на экран простых чисел в диапазоне 0 - " + input + ":");
            AllPrimeNumbers(input);
        }
        static bool PrimeOrNot(int inputNumber)
        {
            var primeNumber = true;
            int divider;
            for (divider = 2; divider < inputNumber; divider++)
            {
                if (inputNumber % divider == 0)
                {
                    primeNumber = false;
                    break;
                }
            }
            return primeNumber;
        }
        static void AllPrimeNumbers(int inputNumber)
        {
            for (int allPrimes = 2; allPrimes <= inputNumber; allPrimes++)
            {
                var prime = PrimeOrNot(allPrimes);
                if (prime)
                {
                    Console.Write(allPrimes + " ");
                }
            }
        }
    }


}
