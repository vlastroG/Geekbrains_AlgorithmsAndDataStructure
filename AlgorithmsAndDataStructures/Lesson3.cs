using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    public class Lesson3 : ILesson
    {
        public string Name => "lesson2";

        public string Description => "Сравнение производительности class и struct";

        public void Demo()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Создает массив заданного количества точек (ссылочного типа), расположенных в Декартовой системе координат
        /// </summary>
        /// <param name="countPoints">Количество создаваемых точек</param>
        /// <returns>Массив созданных точек</returns>
        public static PointClassDouble[] CreatePointClassArr(int countPoints)
        {
            PointClassDouble[] pointClassArr = new PointClassDouble[countPoints];
            Random rnd = new Random();
            for (int i = 0; i < countPoints; i++)
            {
                PointClassDouble point = new PointClassDouble();
                point.X = rnd.NextDouble();
                point.Y = rnd.NextDouble();
                point.Z = rnd.NextDouble();
                pointClassArr[i] = point;
            }
            return pointClassArr;
        }
        /// <summary>
        /// Создает массив заданного количества точек (значимого типа), расположенных в Декартовой системе координат
        /// </summary>
        /// <param name="countPoints">Количество создаваемых точек</param>
        /// <returns>Массив созданных точек</returns>
        public static PointStructDouble[] CreatePointStructArr(int countPoints)
        {
            PointStructDouble[] pointStructArr = new PointStructDouble[countPoints];
            Random rnd = new Random();
            for (int i = 0; i < countPoints; i++)
            {
                PointStructDouble point = new PointStructDouble();
                point.X = rnd.NextDouble();
                point.Y = rnd.NextDouble();
                point.Z = rnd.NextDouble();
                pointStructArr[i] = point;
            }
            return pointStructArr;
        }
        /// <summary>
        /// Сравнение производительности вычисления расстояний между точками class и struct
        /// </summary>
        public static void SpeedComparison()
        {
            // Ввод количества тестов
            int countOfTests = Convert.ToInt32(Program.GetStringFromUser("Введите количество тестов сравнения"));

            // Шапка вывода
            Console.WriteLine("Points\t|\tPointStructDouble\t|\tPointClassDouble\t|\tRatio");

            // Проведение теста сравнения производительности для разного количества точек
            for (int i = 0; i < countOfTests; i++)
            {
                int countOfPoints = Convert.ToInt32(Program.GetStringFromUser("Введите количество точек"));
                PointClassDouble[] pointClassArr = CreatePointClassArr(countOfPoints);
                PointStructDouble[] pointStructArr = CreatePointStructArr(countOfPoints);

                // Вычисление расстояний для классов точек
                Stopwatch stopWatch1 = new Stopwatch();
                stopWatch1.Start();
                GetPointsDistance(pointClassArr);
                stopWatch1.Stop();
                TimeSpan ts1 = stopWatch1.Elapsed;

                // Вычисление расстояний для структур точек
                Stopwatch stopWatch2 = new Stopwatch();
                stopWatch2.Start();
                GetPointsDistance(pointStructArr);
                stopWatch2.Stop();
                TimeSpan ts2 = stopWatch2.Elapsed;

                Console.WriteLine($"{countOfPoints}\t|\t{ts2}\t|\t{ts1}\t|\t{(ts1) / (ts2)}");
            }
        }
        /// <summary>
        /// Ссылочный тип точки - класс
        /// </summary>
        public class PointClassDouble
        {
            public double X;
            public double Y;
            public double Z;
        }
        /// <summary>
        /// Значимый тип точки - структура
        /// </summary>
        public struct PointStructDouble
        {
            public double X;
            public double Y;
            public double Z;
        }
        /// <summary>
        /// Расчитывает расстояния между точками классового типа из массива
        /// </summary>
        /// <param name="arr">Передаваемый функции массив</param>
        public static void GetPointsDistance(PointClassDouble[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < (length - 1); i++)
            {
                double distance = Math.Pow((arr[i + 1].X - arr[i].X), 2) + Math.Pow((arr[i + 1].Y - arr[i].Y), 2) + Math.Pow((arr[i + 1].Z - arr[i].Z), 2);
            }
        }
        /// <summary>
        /// Расчитывает расстояния между точками значимого типа из массива
        /// </summary>
        /// <param name="arr">Передаваемый функции массив</param>
        public static void GetPointsDistance(PointStructDouble[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < (length - 1); i++)
            {
                double distance = Math.Pow((arr[i + 1].X - arr[i].X), 2) + Math.Pow((arr[i + 1].Y - arr[i].Y), 2) + Math.Pow((arr[i + 1].Z - arr[i].Z), 2);
            }
        }

    }
}
