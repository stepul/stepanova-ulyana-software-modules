/*namespace лаба_12_13
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            string input1 = Console.ReadLine();
            int number = Convert.ToInt32(input1);
            Console.WriteLine(Math.Abs(number) >= 10 && Math.Abs(number) <= 99 ? "Двузначное" : "Не двузначное");
        }
    }
}*/

/*namespace лаба_12_13
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число: ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);
            Console.WriteLine("Введите второе число: ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);
            Console.WriteLine("Введите третье число: ");
            string input3 = Console.ReadLine();
            int number3 = Convert.ToInt32(input3);
            Console.WriteLine("Введите четвёртое число: ");
            string input4 = Console.ReadLine();
            int number4 = Convert.ToInt32(input4);
            int count = 0;

            if (number1 < 0) count++;
            if (number2 < 0) count++;
            if (number3 < 0) count++;
            if (number4 < 0) count++;
            Console.WriteLine($"Количество отрицательных чисел: {count}");
        }
    }
}*/

/*namespace лаба_12_13
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите код валюты: ");
            string code_val = Console.ReadLine();
            switch (code_val)
            {
                case "USD":
                    Console.WriteLine("Валюта - доллар США");
                    break;
                case "EUR":
                    Console.WriteLine("Валюта - евро");
                    break;
                case "RUB":
                    Console.WriteLine("Валюта - российский рубль");
                    break;
                case "KZT":
                    Console.WriteLine("Валюта - казахстанский тенге");
                    break;
                default:
                    Console.WriteLine("Что-то не то ввели");
                    break;
            }
        }
    }
}*/

/*namespace лаба_12_13
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите сумму перевода: ");
            double summa = Convert.ToDouble(Console.ReadLine());

            if (summa < 0)
            {
                Console.WriteLine("Сумма не может быть отрицательной");
                return;
            }
            double commission = summa switch
            {
                <= 1000 => summa * 0.01,
                <= 10000 => summa * 0.005,
                _ => summa * 0.0025
            };
            Console.WriteLine($"Комиссия: {commission}");
        }
    }
}*/
