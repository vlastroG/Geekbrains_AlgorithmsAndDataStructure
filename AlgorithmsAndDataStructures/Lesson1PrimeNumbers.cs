using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class Lesson1PrimeNumbers : ILesson
    {
        public string Name => "prime";

        public string Description => "1.1. Анализ принадлежности к множеству простых чисел";

        public void Demo()
        {
            long value1 = 34651356659872;
            Console.WriteLine($"Является {value1} простым числом? ");
            long value2 = 199;
            Console.WriteLine($"Является {value2} простым числом? ");
        }

        private bool EvenOddNumber(string input)
        {


            if (ulong.TryParse(input, out ulong result))
            {
                ulong number = ulong.Parse(input);
                string output_string = "";
                bool output_bool;
                int d = 0;
                uint i = 2;
                while (i < number)
                {
                    if (number % i == 0)
                    {
                        // Количество делений
                        d++;
                        i++;
                    }
                    else
                    {
                        // Увеличить сравниваемое
                        i++;
                    }
                }
                if (d == 0)
                {
                    // number - простое
                    output_string = $"Введенное число {input} - простое.";
                    Console.WriteLine(output_string);
                    output_bool = true;
                }
                else
                {
                    // number - не простое
                    output_string = $"Введенное число {input} - не простое.";
                    Console.WriteLine(output_string);
                    output_bool = false;
                }
                return output_bool;
            }
            else
            {
                Console.WriteLine("Некорректный ввод! Введите положительное целое число:");
                return EvenOddNumber(Console.ReadLine());
            }
        }
        public static void CheckCorrect()
        {
            Console.WriteLine("=======================================================================");
            string correct = "9845612";
            Console.WriteLine($"Результат выполнения программы при правильном вводе '{correct}', например");
            Lesson1.EvenOddNumber(correct);
        }
        public static void CheckIncorrect()
        {
            Console.WriteLine("=======================================================================");
            string incorrect = "ифм34";
            Console.WriteLine($"Результат выполнения программы при некорректном вводе '{incorrect}', например");
            Lesson1.EvenOddNumber(incorrect);
            Console.WriteLine("=======================================================================");

        }
    }
}
