/*using System;
class Program
{
    static void Main()
    {
        double eps;
        bool valid;
        do
        {
            Console.Write("Введите eps (0,000001–1): ");
            string input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Ввод завершён");
                return;
            }

            valid = double.TryParse(input, out eps)
                    && eps >= 0.000001 && eps <= 1;

            if (!valid)
                Console.WriteLine("Нужно число от 0,000001 до 1.");
        }
        while (!valid);

        double sum = 1;
        double number = 1;

        number /= 2;

        while (number >= eps)
        {
            sum += number;
            number /= 2;
        }

        Console.WriteLine($"Сумма: {sum}");
    }
}*/


/*using System;
class Program
{
    static void Main()
    {
        double A;
        double eps;
        bool valid;

        // Ввод A
        do
        {
            Console.Write("Введите амплитуду A (1–100): ");
            string input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Ввод завершён");
                return;
            }

            valid = double.TryParse(input, out A) && A >= 1 && A <= 100;

            if (!valid)
                Console.WriteLine("Нужно число от 1 до 100.");
        }
        while (!valid);

        // Ввод eps
        do
        {
            Console.Write("Введите eps (0,000001–100): ");
            string input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Ввод завершён");
                return;
            }

            valid = double.TryParse(input, out eps)
                    && eps >= 0.000001 && eps <= 100;

            if (!valid)
                Console.WriteLine("Нужно число от 0,000001 до 100.");
        }
        while (!valid);

        int step = 0;

        while (A > eps)
        {
            A /= 2;
            step++;
        }

        Console.WriteLine($"Шагов: {step}");
    }
}*/