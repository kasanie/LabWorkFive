using System;

namespace LabWorkFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            Console.WriteLine("Введите число:");
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out inputNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка. Введите число:");
                    continue;
                }
            }
            var isPrimeNumber = true;
            int divider;
            for (divider = 2; divider < inputNumber; divider++)
            {
                if (inputNumber % divider == 0)
                {
                    isPrimeNumber = false;
                    break;
                }
            }
            if (isPrimeNumber)
            {
                Console.WriteLine("Число " + inputNumber + " простое");
            }
            else
            {
                Console.WriteLine("Число " + inputNumber + " не является простым");
            }
            Console.WriteLine("Вывод на экран простых чисел в диапазоне 0 - " + inputNumber + ":");
            int allPrimeNumbers;
            for (allPrimeNumbers = 2; allPrimeNumbers <= inputNumber; allPrimeNumbers++)
            {
                isPrimeNumber = true;
                for (divider = 2; divider < allPrimeNumbers; divider++)
                {
                    if (allPrimeNumbers % divider == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    Console.Write(allPrimeNumbers + " ");
                }
            }
        }
    }
}
