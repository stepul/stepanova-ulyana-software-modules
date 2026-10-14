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

/*Общее задание 3 using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Привет!");

        int choice;
        int count = 0;
        bool valid;

        do
        {
            Console.WriteLine("ЙОУ привет!!");

            Console.Write("Повтор? (1 — да, 0 — нет) ");
            string input = Console.ReadLine();

            valid = int.TryParse(input, out choice)
                    && (choice == 0 || choice == 1);

            if (!valid)
            {
                Console.WriteLine("Нужно 1 - или 0 - нет");
            }
            else if (choice == 1)
            {
                count++;
            }
        }
        while (!valid || choice == 1);

        Console.WriteLine("Конец..");
        Console.WriteLine($"Повторов: {count}");
    }
}
*/
