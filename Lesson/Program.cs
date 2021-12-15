using System;

namespace MyNoFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Привет, как тебя зовут?");
            string name = System.Console.ReadLine(); // Присваивание значения переменной
            System.Console.WriteLine($" Привет, {name}! Сейчас {DateTime.Now}"); //Вывод данных
        }
    }
}
