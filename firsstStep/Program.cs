using System;
using System.Diagnostics;

public class Example
{
    public static void Main(string[] args)
    {
        Console.Write("Введите ваш возраст: ");

        int age;
        while (!int.TryParse(Console.ReadLine
            (), out age))
        {
            Console.Write("Введите число пожалуйста: ");
        }
        if (age < 18)
        {
            Console.WriteLine($"Приходите через {18 - age} лет");
        }
        else
        {
            Process.Start("https://www.youtube.com/watch?v=w8rRhAup4kg&t=11s");
            Console.WriteLine("Ссылка открыта в браузере");
        }

    }
}
