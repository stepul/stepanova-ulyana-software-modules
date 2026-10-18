/* общее задание 1
using System;
class Program
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.Length; i++)
            alphabet[i] = (char)('A' + i);
        foreach (char letter in alphabet)
            Console.Write(letter + " ");
        Console.WriteLine();
    }
}*/

/* общее задание 2
using System;
class Program
{
    static void Main()
    {
        char[] alphabet = new char[33];
        int index = 0;

        for (char c = 'А'; c <= 'Я'; c++)
        {
            alphabet[index] = c;
            index++;

            if (c == 'Е')
            {
                alphabet[index] = 'Ё';
                index++;
            }
        }
        foreach (char letter in alphabet)
            Console.Write(letter + " ");
    }
}*/

/* общее задание 3 
using System;
class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = i + 1;
        int sum = 0;
        foreach (int value in numbers)
            sum += value;
        Console.WriteLine("Сумма: " + sum);
    }
}*/

/* общее задание 4
using System;
class Program
{
    static void Main()
    {
        string[] source = { "Привет", "", "  ", "Мир", "", "!" };
        List<string> result = new List<string>();
        foreach (string text in source)
        {
            if (text.Trim() != "")
            {
                result.Add(text);
            }
        }
        Console.WriteLine("Непустые строки:");
        foreach (string text in result)
        {
            Console.WriteLine(text);
        }
    }
}*/

/* общее задание 5
using System;
class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }

        int sum = 0;
        foreach (int value in numbers)
        {
            sum += value;
        }
        Console.WriteLine("Сумма основного массива: " + sum);

        int[] empty = new int[0];
        int sumEmpty = 0;

        foreach (int value in empty)
        {
            sumEmpty += value;
        }
        Console.WriteLine("Сумма пустого массива: " + sumEmpty);

        int[] one = { 42 };
        int sumOne = 0;

        foreach (int value in one)
        {
            sumOne += value;
        }
        Console.WriteLine("Сумма массива из 1 элемента: " + sumOne);
    }
}*/

/* задание а1
using System;
class Program
{
    static void Main()
    {
        int n;
        bool check;

        do
        {
            Console.Write("Введите N (0-10000): ");
            string text = Console.ReadLine();

            if (text == null)
            {
                Console.WriteLine("Ввод завершён");
                return;
            }

            check = int.TryParse(text, out n) && n >= 0 && n <= 10000;
            if (check == false)
                Console.WriteLine("Нужно целое число от 0 до 10000.");
        }
        while (check == false);

        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + 1.0 / i;
        }

        Console.WriteLine("Сумма: " + sum);
    }
}*/

/* задание б1
using System;
class Program
{
    static void Main()
    {
        int n;
        bool check;

        do
        {
            Console.Write("Сколько дней (1-100)? ");
            string text = Console.ReadLine();
            if (text == null) 
            { 
                Console.WriteLine("Ввод завершён"); 
                return; 
            }
            check = int.TryParse(text, out n) && n >= 1 && n <= 100;
            if (!check) 
                Console.WriteLine("Ошибка, нужно от 1 до 100.");
        }
        while (check == false);

        decimal sum = 0;

        for (int i = 1; i <= n; i++)
        {
            decimal payout;
            bool validPayout;

            do
            {
                Console.Write("Выплата за день " + i + ": ");
                string text = Console.ReadLine();
                if (text == null) 
                { 
                    Console.WriteLine("Ввод завершён"); 
                    return; 
                }
                validPayout = decimal.TryParse(text, out payout) && payout >= 0 && payout <= 1000000;
                if (!validPayout) 
                    Console.WriteLine("Ошибка, нужно от 0 до 1 000 000.");
            }
            while (validPayout == false);

            sum = sum + payout;
        }

        decimal average = sum / n; 
        Console.WriteLine("Средняя выплата: " + average);
    }
}*/

/* задание а2
using System;
class Program
{
    static void Main()
    {
        Random random = new Random();

        double[] data = new double[10];
        for (int i = 0; i < data.Length; i++)
        {

            data[i] = random.Next(-50, 51) / 10.0;
        }

        Console.Write("Массив: ");
        foreach (double value in data)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        double sum = 0;
        int count = 0;

        foreach (double value in data)
        {
            if (value > 0)
            {
                sum += value;
                count++;
            }
        }

        if (count > 0)
            Console.WriteLine("Среднее положительных: " + sum / count);
        else
            Console.WriteLine("Положительных элементов нет.");
    }
}*/

/* задание б2
using System;
class Program
{
    static void Main()
    {
        Random random = new Random();
        double[] temps = new double[10];

        Console.Write("Температуры за дни: ");
        for (int i = 0; i < temps.Length; i++)
        {

            temps[i] = random.Next(-30, 31);
            Console.Write(temps[i] + " ");
        }
        Console.WriteLine();

        double sum = 0;
        int count = 0;

        foreach (double t in temps)
        {
            if (t < 0)
            {
                sum += t;
                count++;
            }
        }
        if (count > 0)
            Console.WriteLine("Средняя отрицательная температура: " + (sum / count));
        else
            Console.WriteLine("Отрицательных температур нет.");
    }
}*/