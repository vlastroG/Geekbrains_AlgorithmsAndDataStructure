using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgorithmsAndDataStructures.Program;

namespace AlgorithmsAndDataStructures
{
    public class Lesson1
    {
        /// <summary>
        /// Домашнее задание к 1 уроку
        /// </summary>
        public static void lesson1_homework()
        {
            //lesson1_Fibbonacci.Fibonacci();

            CheckCorrect();
            CheckIncorrect();

            Console.WriteLine("========================Выполнение программы===========================");



            string exit = "exit";
            string input;
            do
            {
                Console.WriteLine("Введите положительное целое число:");
                EvenOddNumber(Console.ReadLine());
                input = GetStringFromUser("Для выхода из приложения введите 'exit' или нажмите 'enter' для продолжения").ToLower();
            } while (input != exit);

            Console.WriteLine("Нажмите Enter для завершения работы приложения.");
            Console.ReadLine();
        }
        public static bool EvenOddNumber(string input)
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
            EvenOddNumber(correct);
        }
        public static void CheckIncorrect()
        {
            Console.WriteLine("=======================================================================");
            string incorrect = "ифм34";
            Console.WriteLine($"Результат выполнения программы при некорректном вводе '{incorrect}', например");
            EvenOddNumber(incorrect);
            Console.WriteLine("=======================================================================");

        }



    }
}


