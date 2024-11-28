using Tyuiu.PasechnikPA1.Sprint1.Task2.V17.Lib;
namespace Tyuiu.PasechnikPA1.Sprint1.Task2.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Пасечник П. А. | АСОиУБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #17                                                            *");
            Console.WriteLine("* Выполнил: Пасечник Павел Андреевич | АСОиУБ-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество минут:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"* РЕЗУЛЬТАТ: {x} мин. = {ds.ConvertMinutesToHours(x)} сек.");
            Console.WriteLine("***************************************************************************");
            Console.ReadLine();
        }
    }
}
