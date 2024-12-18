﻿using Tyuiu.PasechnikPA1.Sprint1.Task4.V15.Lib;
namespace Tyuiu.PasechnikPA1.Sprint1.Task4.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Пасечник П. А. | АСОиУБ-24-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                       *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                                                *");
            Console.WriteLine("* Задание #4                                                                                      *");
            Console.WriteLine("* Вариант #15                                                                                     *");
            Console.WriteLine("* Выполнил: Пасечник Павел Андреевич | АСОиУБ-24-1                                                *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат     *");
            Console.WriteLine("* по формуле и печатает его на экране. Ответ округлите до 3 знаков после запятой.                 *");
            Console.WriteLine("* Формула: (x + y^2)e^2−4y                                                                        *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            double x, y;
            Console.Write("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine("(x+y^2) / e^2-4y) = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
