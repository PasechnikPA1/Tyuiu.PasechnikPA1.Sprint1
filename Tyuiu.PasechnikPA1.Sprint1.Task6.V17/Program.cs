using Tyuiu.PasechnikPA1.Sprint1.Task6.V17.Lib;
namespace Tyuiu.PasechnikPA1.Sprint1.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Пасечник П. А. | АСОиУБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Пасечник Павел Андреевич | АСОиУБ-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая определяет, является ли                     *");
            Console.WriteLine("* строка палиндромом                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string x;

            Console.WriteLine("Введите строку, которые вы хотите проверить на палиндром:");

            x = Console.ReadLine();

            var check = ds.CheckPalindrome(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (check == true)
            {
                Console.WriteLine("Да, строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Нет, строка не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
