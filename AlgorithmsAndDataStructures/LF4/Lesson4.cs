using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsAndDataStructures;

namespace AlgorithmsAndDataStructures.LF4
{
    public class Lesson4 : ILesson
    {
        public string Name => "lesson4";

        public string Description => "Деревья и хэш-таблицы";

        public void Demo()
        {
            task2();
            task1();
        }
        /// <summary>
        /// Задание №1, реализация класса дерева. Тест команд.
        /// </summary>
        public static void task1()
        {

            BinaryTree tree = new BinaryTree();
            tree.PrintTree();

            tree.RemoveItem(10);

            tree.AddItem(10);
            tree.AddItem(10);


            tree.AddItem(20);
            tree.AddItem(7);
            tree.AddItem(11);
            tree.AddItem(12);
            tree.AddItem(7);
            tree.AddItem(12);
            tree.AddItem(1);
            tree.AddItem(-5);
            tree.AddItem(8);
            tree.AddItem(21);
            tree.AddItem(19);

            tree.GetNodeByValue(19);
            tree.GetNodeByValue(100500);
            int n = 40;
            tree.PrintTree();
            tree.RemoveItem(10);
            Console.WriteLine(new string('=', n));
            tree.PrintTree();
            Console.WriteLine(new string('=', n));
            tree.RemoveItem(8);
            tree.PrintTree();
            Console.WriteLine(new string('=', n));
            tree.RemoveItem(12);
            tree.PrintTree();
            Console.WriteLine(new string('=', n));
            tree.RemoveItem(11);
            tree.PrintTree();
            Console.WriteLine(new string('=', n));
            tree.RemoveItem(1);
            tree.PrintTree();
        }
        /// <summary>
        /// Задание 2. Сравнение производительности поиска строки в массиве и hashset.
        /// </summary>
        public static void task2()
        {
            int length = 1000000;
            string search = "1999";
            string[] arrayString = new string[length + 1];
            var hashSet = new HashSet<string>();

            Random rnd = new Random();

            // заполнение массива
            for (int i = 0; i < arrayString.Length; i++)
            {
                arrayString[i] = rnd.Next().ToString();
            }
            arrayString[length - 1] = search;

            // заполнение hashset
            for (int i = 0; i < length; i++)
            {
                hashSet.Add(rnd.Next().ToString());
            }
            hashSet.Add(search);

            // Шапка вывода
            Console.WriteLine("length\t|\tArray\t\t\t|\tHashSet\t\t\t|\tRatio");
            SpeedRate(hashSet, arrayString, search, length);//элемент для поиска в самом конце 

            // изменение массива. Теперь элемент для поиска в середине
            arrayString[length - 1] = "235";
            arrayString[length / 2] = search;

            // перезаполнение hashset теперь элемент для поиска в середине
            hashSet.Clear();
            for (int i = 0; i < length / 2; i++)
            {
                hashSet.Add(rnd.Next().ToString());
            }
            hashSet.Add(search);
            for (int i = (length / 2 + 1); i < length; i++)
            {
                hashSet.Add(rnd.Next().ToString());
            }
            SpeedRate(hashSet, arrayString, search, length);//элемент для поиска в самом конце 

            // изменение массива. Теперь элемент для поиска в самом начале
            arrayString[length / 2] = "235";
            arrayString[0] = search;

            // перезаполнение hashset теперь элемент для поиска в самом начале
            hashSet.Clear();
            hashSet.Add(search);
            for (int i = 1; i < length; i++)
            {
                hashSet.Add(rnd.Next().ToString());
            }

            SpeedRate(hashSet, arrayString, search, length);//элемент для поиска в самом конце 


        }
        /// <summary>
        /// Сравнинает скорости выполнения поиска в массиве и hashset
        /// </summary>
        /// <param name="hashSet">Input hashset</param>
        /// <param name="arrayString">Input array string</param>
        /// <param name="search">String parameter to search</param>
        /// <param name="length">Length of hashset and string array</param>
        private static void SpeedRate(HashSet<string> hashSet, string[] arrayString, string search, int length)
        {
            // Время на поиск в array
            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            arrayString.Contains(search);
            stopWatch1.Stop();
            TimeSpan ts1 = stopWatch1.Elapsed;

            // Время на поиск в hashset
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            hashSet.Contains(search);
            stopWatch2.Stop();
            TimeSpan ts2 = stopWatch2.Elapsed;

            Console.WriteLine($"{length}\t|\t{ts1}\t|\t{ts2}\t|\t{(ts1) / (ts2)}");
        }
    }
}
