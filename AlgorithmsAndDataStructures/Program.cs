using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AlgorithmsAndDataStructures
{


    internal class Program
    {
        static List<ILesson> _lessons = new List<ILesson>()
        {
            new Lesson1PrimeNumbers()
        };
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            IConfiguration configuration = BuildConfig(builder);

            Log.Logger = new LoggerConfiguration()
                            .ReadFrom.Configuration(configuration)
                            .CreateLogger();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Log.Logger.Verbose("Приложение запущено");
            Log.Logger.Debug("Приложение запущено");
            Log.Logger.Information("Приложение запущено");
            Log.Logger.Warning("Приложение запущено");
            Log.Logger.Error("Приложение запущено");

            // Выбросить необработанное исключение - пример, как бывает.
            // throw new NotSupportedException("необработанное исключение");

            // Демонстрация работы двусвязанного списка
            Lesson2.testNodeList();

            // Lesson1.lesson1_homework();

            Lesson3.SpeedComparison();

            Console.WriteLine($"Для запуска задания введите его код. Доступные задания:");
            foreach (ILesson lesson in _lessons)
            {
                Console.WriteLine($"код: {lesson.Name} ({lesson.Description})");
            }


        }

        /// <summary>
        /// Записывает необработанное исключение.
        /// </summary>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception unhandledException = (Exception)e.ExceptionObject;
            Log.Error(unhandledException, "Необработанное исключение");
        }

        /// <summary>
        /// Подключает файл конфигурации из каталога с приложением и возвращает конфигурацию.
        /// </summary>
        /// 
        static IConfiguration BuildConfig(IConfigurationBuilder builder)
        {
            return
                builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        /// <summary>
        /// Return string from user based on message to user
        /// </summary>
        /// <param name="messageToUser"></param>
        /// <returns></returns>
        public static string GetStringFromUser(string messageToUser)
        {
            Console.WriteLine(messageToUser);
            return Console.ReadLine();
        }
    }
}
