using System;

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