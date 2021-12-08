using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Diagnostics;
using System.IO;

namespace AlgorithmsAndDataStructures
{
    internal class Program
    {
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
            //throw new NotSupportedException("необработанное исключение");

            
            //lesson1_Fibbonacci.Fibonacci();
            
            
            lesson1.CheckCorrect();
            lesson1.CheckIncorrect();

            Console.WriteLine("========================Выполнение программы===========================");



            string exit = "exit";
            string input;
            do
            {
                Console.WriteLine("Введите положительное целое число:");
                lesson1.EvenOddNumber(Console.ReadLine());
                input = GetStringFromUser("Для выхода из приложения введите 'exit' или нажмите 'enter' для продолжения").ToLower();
            } while (input != exit);

            Console.WriteLine("Нажмите Enter для завершения работы приложения.");
            Console.ReadLine();


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
