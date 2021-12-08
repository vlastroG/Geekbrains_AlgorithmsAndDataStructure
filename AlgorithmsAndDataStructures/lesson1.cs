using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgorithmsAndDataStructures.Program;

namespace AlgorithmsAndDataStructures
{
    public class lesson1
    {
        public static bool EvenOddNumber(string input)
        {
            
            
            if (ulong.TryParse(input, out ulong result))
            {
                ulong number = ulong.Parse(input);
                string output_string = "";
                bool output_bool;
                int d = 0;
                uint i = 2;
                while (i<number)
                {
                    if (number%i==0)
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
                if (d==0)
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
            lesson1.EvenOddNumber(correct);
        }
        public static void CheckIncorrect()
        {
            Console.WriteLine("=======================================================================");
            string incorrect = "ифм34";
            Console.WriteLine($"Результат выполнения программы при некорректном вводе '{incorrect}', например");
            lesson1.EvenOddNumber(incorrect);
            Console.WriteLine("=======================================================================");

        }



    }
}


