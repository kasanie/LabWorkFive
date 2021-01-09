using System;

namespace LabWorkFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Введите число:");
            for(;;)             
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
            PrimeOrNot(input);
            Console.WriteLine("Вывод на экран простых чисел в диапазоне 0 - " + input + ":");
            AllPrimeNumbers(input);
        }
        static void PrimeOrNot(int inputNumber)
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
            if (primeNumber)
            {
                Console.WriteLine("Число " + inputNumber + " простое");
            }
            else
            {
                Console.WriteLine("Число " + inputNumber + " не является простым");
            }
        }
        static void AllPrimeNumbers(int inputNumber)
        {
            for (int allPrimes = 2; allPrimes <= inputNumber; allPrimes++)
            {
                var primeNumber = true;
                for (int divider = 2; divider < allPrimes; divider++)
                {
                    if (allPrimes % divider == 0)
                    {
                        primeNumber = false;
                        break;
                    }
                }
                if (primeNumber)
                {
                    Console.Write(allPrimes + " ");
                }
            }
        }

    }
}
