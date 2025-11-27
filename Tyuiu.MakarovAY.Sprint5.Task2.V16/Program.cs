using System.Runtime.ExceptionServices;
using Tyuiu.MakarovAY.Sprint5.Task2.V16.Lib;
namespace Tyuiu.MakarovAY.Sprint5.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3] { {2, 4, 8 }, {3, -7, -2}, {3, 8, 6} };
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;
            Console.Title = "Спринт #5 | Выполнил: Макаров А. Я. | РППБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс file                                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Макаров А. Я. | РППБ-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
            Console.WriteLine("* отрицательные на 0.                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < rows; i++) 
            {
                for (j = 0; j < colums; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }

}