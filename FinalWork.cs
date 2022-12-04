using System;
using System.Linq;
namespace FinalWork
{
    class Program
    {
        static void Main()
        {
            try
            {
                do
                {
                    PrintStartTask(taskName: "ИТОГОВАЯ",
                                   taskText: "на входе массив строк, на выходе новый массив на основе исходного, в котором длина элементов меньше либо равна 3-м символам.",
                                   infoText: "элементы перечисляются через запятую. Пробелы учитываются как символы!");

                    Console.WriteLine();
                    Console.Write("Введите элементы массива: ");
                    string[] array = Console.ReadLine()!.Split(","); // ввод пользователем массива строк





                } while (CKey() != ConsoleKey.Escape);
            }
            catch (Exception e)
            {
                ExceptionMessage(e.Message);
            }
        }

        /// <summary>
        /// выводит заверщающий текст и возвращает нажатую пользователем клавишу
        /// </summary>
        /// <returns>ConsoleKey</returns>
        static ConsoleKey CKey()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("* для завершения задачи нажмите ESC или любую другую клавишу, чтобы повторить выполнение...");
            return Console.ReadKey(true).Key;
        }

        /// <summary>
        /// вывод заголовка задачи
        /// </summary>
        /// <param name="taskName">название задачи</param>
        /// <param name="taskText">текст задачи</param>
        /// <param name="infoText">дополнительная информация (необязательный параметр)</param>
        static void PrintStartTask(string taskName, string taskText, string infoText = "")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"ЗАДАЧА {taskName}: " + taskText);
            if (infoText != "")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("info: " + infoText);
            }
            Console.ResetColor();
        }

        /// <summary>
        /// вывод сообщения с исключением
        /// </summary>
        /// <param name="eMessage">текст исключения</param>
        static void ExceptionMessage(string eMessage)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"критическая ошибка: {eMessage}");
            Console.WriteLine("");
            Console.Write("* нажмите любую клавишу для завершения программы...");
            Console.ResetColor();
            Console.ReadKey(true);
        }
    }
}