using System;
namespace бд
{
    class obiectnedv
    {
        int objectID;
        string address;
        int rooms;
        decimal area;
        int floor;

        public obiectnedv(int new_objectID, string new_address, int new_rooms, decimal new_area, int new_floor)
        {
            objectID = new_objectID;
            address = new_address;
            rooms = new_rooms;
            area = new_area;
            floor = new_floor;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Объект ID: {objectID}, Адрес: {address}, Комнат: {rooms}, Площадь: {area}, Этаж: {floor}");
        }
    }

    class Owner
    {
        int sobstvennikID;
        string last_name;
        string first_name;
        string middle_name;
        string phone;
        string passport;

        public Owner(int new_sobstvennikID, string new_last_name, string new_first_name, string new_middle_name, string new_phone, string new_passport)
        {
            sobstvennikID = new_sobstvennikID;
            last_name = new_last_name;
            first_name = new_first_name;
            middle_name = new_middle_name;
            phone = new_phone;
            passport = new_passport;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Собственник ID: {sobstvennikID}, ФИО: {last_name} {first_name} {middle_name}, Телефон: {phone}");
        }
    }

    class Arendator
    {
        int arendatorID;
        string last_name;
        string first_name;
        string middle_name;
        string phone;

        public Arendator(int new_arendatorID, string new_last_name, string new_first_name, string new_middle_name, string new_phone)
        {
            arendatorID = new_arendatorID;
            last_name = new_last_name;
            first_name = new_first_name;
            middle_name = new_middle_name;
            phone = new_phone;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Арендатор ID: {arendatorID}, ФИО: {last_name} {first_name} {middle_name}, Телефон: {phone}");
        }
    }

    class Contract
    {
        int contractID;
        int objectID;
        string status;
        DateTime start_date;
        DateTime end_date;
        decimal payment;

        public Contract(int new_contractID, int new_objectID, string new_status, DateTime new_start_date, DateTime new_end_date, decimal new_payment)
        {
            contractID = new_contractID;
            objectID = new_objectID;
            status = new_status;
            start_date = new_start_date;
            end_date = new_end_date;
            payment = new_payment;
        }
        
        public void PrintInfo()
        {
            Console.WriteLine($"Договор ID: {contractID}, Объект: {objectID}, Статус: {status}, Период: {start_date:yyyy-MM-dd} - {end_date:yyyy-MM-dd}, Плата: {payment}");
        }
    }
    class Program
    {
        static void Main()
        {
            var obj1 = new obiectnedv(10, "ул. Набережная 99, д. 3, кв. 77", 2, 60, 5);
            var obj2 = new obiectnedv(11, "ул. Гагарина 88, д. 6, кв. 44", 1, 45, 3);

            var owner1 = new Owner(1, "Соколов", "Сергей", "Сергеевич", "+7-900-111-11-11", "4501 123456");
            var owner2 = new Owner(2, "Петрушкин", "Пётр", "Петрович", "+7-900-222-22-22", "4502 456123");

            var arendator1 = new Arendator(3, "Волков", "Виктор", "Викторович", "+7-900-323-23-23");

            var contract1 = new Contract(100, 10, "действует", new DateTime(2026, 12, 1), new DateTime(2027, 12, 31), 50000);

            obj1.PrintInfo();
            obj2.PrintInfo();
            owner1.PrintInfo();
            owner2.PrintInfo();
            arendator1.PrintInfo();
            contract1.PrintInfo();

            Console.ReadLine();
        }
    }
}