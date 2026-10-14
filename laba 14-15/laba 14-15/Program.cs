/* Общее задание 1 
using System;

class Program
{
    static void Main()
    {
        int size;
        bool valid;
        do
        {
            Console.Write("Количество участников (1–30): ");
            string input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Ввод завершён");
                return;
            }
            valid = int.TryParse(input, out size)
                    && size >= 1 && size <= 30;
            if (!valid)
                Console.WriteLine("Нужно целое число от 1 до 30.");
        }
        while (!valid);

        Console.WriteLine($"Принято: {size}");
    }
}*/

/* Общее задание 2
using System;

class Program
{
    static void Main()
    {
        int chislo;
        bool valid;

        do
        {
            Console.Write("Введите  число: ");
            string input = Console.ReadLine();

            valid = int.TryParse(input, out chislo) && chislo >= 0;

            if (!valid)
                Console.WriteLine("Нужно неотрицательное целое число.");
        }
        while (!valid);

        int original = chislo;
        int count = 0;

        do
        {
            count++;
            chislo /= 10;
        }
        while (chislo > 0);

        Console.WriteLine($"Цифр в числе {original}: {count}");
    }
}*/

/*Задание A Вариант 16
using System;
class Program
{
    static void Main()
    {
        int a, b;
        bool valid1, valid2;

        do
        {
            Console.Write("Введите два целых числа (от -1000 до 1000): ");
            valid1 = int.TryParse(Console.ReadLine(), out a);
            valid2 = int.TryParse(Console.ReadLine(), out b);

            if (valid1 && valid2 && a < b && a >= -1000 && a <= 1000 && b >= -1000 && b <= 1000)
            {
                Console.WriteLine($"Пара принята: a = {a}, b = {b}");
            }
            else
            {
                if (!valid2) Console.WriteLine("Введены не числа. Попробуйте ещё раз.");
                if (a >= b) Console.WriteLine("Попробуй ещё раз.");
            }
        } while (a >= b);
    }
}*/

/*Задание B Вариант 16
using System;

class Program
{
    static void Main()
    {
        int a, b;
        bool valid1, valid2;

        do
        {
            Console.Write("Введите два целых числа (от 0 до 23): ");
            valid1 = int.TryParse(Console.ReadLine(), out a);
            valid2 = int.TryParse(Console.ReadLine(), out b);

            if ((valid1 && valid2) && (a >= 0 && a <= 23) && (b >= 0 && b <= 23) && (a < b))
            {
                Console.WriteLine($"Пара принята: a = {a}, b = {b}");
                int dlitelnost = b - a; 
                Console.WriteLine($"Длительность: {dlitelnost} час(а/ов)");
            }
            else
            {
                if (!valid1) Console.WriteLine("Введены не числа. Попробуйте ещё раз.");
                if (!valid2) Console.WriteLine("Введены не числа. Попробуйте ещё раз.");
                if (a >= b) Console.WriteLine("Попробуйте ещё раз.");
            }
        } while (a >= b || !valid1 || !valid2); 
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Привет!");

        char repeatChoice;
        int repeatCount = 0;

        do
        {
            Console.WriteLine("ЙОУ привеп!!");
            repeatCount++;
            Console.Write("Хочешь повторить? ");
            string input = Console.ReadLine()?.Trim().ToLower();
            repeatChoice = input.Length > 0 ? input[0] : 'n';
        }
        while (repeatChoice == 'д' || repeatChoice == 'y');

        Console.WriteLine("Программа завершена.");
        Console.WriteLine($"Ты повторил {repeatCount - 1} раз(а).");
    }
}
*/