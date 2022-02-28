using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");

            string name = Console.ReadLine(); //объявляем переменную типа string и присваиваем ей значение, считывая данные пользователя.
            DateTime date = DateTime.Now; //объявляем переменную типа DateTime и присваиваем ей текущее время и дату.

            Console.WriteLine($"Hello, {name}. Today is {date.ToShortDateString()}"); //выводим на консоль имя и дату в заданном формате.
            Console.ReadKey();
        }
    }
}
