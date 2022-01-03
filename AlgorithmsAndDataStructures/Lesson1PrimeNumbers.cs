using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class Lesson1PrimeNumbers : ILesson
    {
        /// <summary>
        /// Название, которое нужно ввести для старта выполнения дз.
        /// </summary>
        public string Name => "lesson1.1";
        /// <summary>
        /// Краткое описание урока
        /// </summary>
        public string Description => "1.1. Анализ принадлежности к множеству простых чисел";
        /// <summary>
        /// Функция демонстрации выполнения задания
        /// </summary>
        public void Demo()
        {
            long value1 = 3465135602;
            Console.WriteLine($"Является {value1} простым числом? ");
            EvenOddNumber(value1.ToString());
            long value2 = 199;
            Console.WriteLine($"Является {value2} простым числом? ");
            EvenOddNumber(value2.ToString());
        }
        /// <summary>
        /// Определяет, является ли введенное число простым.
        /// </summary>
        /// <param name="input">Вводимое число.</param>
        /// <returns>Простое число или нет (bool).</returns>
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
        /// <summary>
        /// Проверка функции EvenOddNumber при корректном вводе
        /// </summary>
        public static void CheckCorrect()
        {
            Console.WriteLine("=======================================================================");
            string correct = "9845612";
            Console.WriteLine($"Результат выполнения программы при правильном вводе '{correct}', например");
            Lesson1.EvenOddNumber(correct);
        }
        /// <summary>
        /// Проверка функции EvenOddNumber при некорректном вводе
        /// </summary>
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
