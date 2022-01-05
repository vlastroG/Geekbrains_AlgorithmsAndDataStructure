using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlgorithmsAndDataStructures
{
    class lesson1_Fibbonacci : ILesson
    {
        /// <summary>
        /// Название, которое нужно ввести для старта выполнения дз.
        /// </summary>
        public string Name => "lesson1.2";
        /// <summary>
        /// Краткое описание урока
        /// </summary>
        public string Description => "1.2. Сравнивает скорость вычисления чила Фибоначчи по его порядковому номеру через рекурсию и цикл.";

        /// <summary>
        /// Выводит число Фибоначчи в консоль по его порядковому номеру по циклу и по рекурсии
        /// </summary>
        public static void Fibonacci()
        {
            var FibonacciNumber = GetIntFromUser("Напишите порядковый номер числа Фибоначчи:");

            // Цикл
            Stopwatch stopWatch1 = new Stopwatch();

            stopWatch1.Start();
            var FibonacciValueCycle = GetFibonacciCycle(FibonacciNumber);
            stopWatch1.Stop();

            Console.WriteLine($"Значение числа Фибоначчи с порядковым номером {FibonacciNumber}, вычисленное с помощью цикла, равно {FibonacciValueCycle}");
            TimeSpan ts = stopWatch1.Elapsed;

            Console.WriteLine($"На вычисление циклом потребовалось {ts.TotalMilliseconds} ms");

            // Рекурсия
            Stopwatch stopWatch2 = new Stopwatch();

            stopWatch2.Start();
            var FibonacciValueRecursion = GetFibonacciRecursion(FibonacciNumber);
            stopWatch2.Stop();

            Console.WriteLine($"Значение числа Фибоначчи с порядковым номером {FibonacciNumber}, вычисленное с помощью рекурсии, равно {FibonacciValueRecursion}");
            TimeSpan ts2 = stopWatch2.Elapsed;

            Console.WriteLine($"На вычисление рекурсией потребовалось {ts2.TotalMilliseconds} ms");

        }
        /// <summary>
        /// Возвращает значение числа Фибоначчи по его порядковому номеру, расчет по рекурсии
        /// </summary>
        /// <param name="FibonacciNumber"></param>
        /// <returns></returns>
        static int GetFibonacciRecursion(int FibonacciNumber)
        {

            if ((FibonacciNumber == 1) || (FibonacciNumber == 2))
            {

                return 1;
            }
            else
            {

                return GetFibonacciRecursion(FibonacciNumber - 1) + GetFibonacciRecursion(FibonacciNumber - 2);
            }

        }

        /// <summary>
        /// Возвращает значение числа Фибоначчи по его порядковому номеру, расчет по циклу
        /// </summary>
        /// <param name="FibonacciNumber"></param>
        /// <returns></returns>
        static int GetFibonacciCycle(int FibonacciNumber)
        {

            var FibonacciNumber1 = 1;
            var FibonacciNumber2 = 1;
            int i = 0;
            while (i < FibonacciNumber - 2)
            {
                int FibonacciSum = FibonacciNumber1 + FibonacciNumber2;
                FibonacciNumber1 = FibonacciNumber2;
                FibonacciNumber2 = FibonacciSum;
                i++;
            }

            return FibonacciNumber2;

        }
        /// <summary>
        /// Запрашивает и возвращает целое число >=1
        /// </summary>
        /// <param name="messageToUser"></param>
        /// <returns></returns>
        static int GetIntFromUser(string messageToUser)
        {
            Console.WriteLine(messageToUser);
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {

                return number;
            }
            else
            {
                return GetIntFromUser("Введите целое число, большее или равное единице:");
            }
        }
        /// <summary>
        /// Функция демонстрации выполнения задания
        /// </summary>
        public void Demo()
        {
            Fibonacci();
        }
    }
}
