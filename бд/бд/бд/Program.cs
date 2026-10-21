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
    }

    class Sobstvennik
    {
        int sobstvennikID;
        string last_name;
        string first_name;
        string middle_name;
        string phone;
        string passport;

        public Sobstvennik(int new_sobstvennikID, string new_last_name, string new_first_name, string new_middle_name, string new_phone, string new_passport)
        {
            sobstvennikID = new_sobstvennikID;
            last_name = new_last_name;
            first_name = new_first_name;
            middle_name = new_middle_name;
            phone = new_phone;
            passport = new_passport;
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
    }

    class Agent
    {
        int agentID;
        string last_name;
        string first_name;
        string middle_name;
        string phone;
        string agent_number;

        public Agent(int new_agentID, string new_last_name, string new_first_name, string new_middle_name, string new_phone, string new_agent_number)
        {
            agentID = new_agentID;
            last_name = new_last_name;
            first_name = new_first_name;
            middle_name = new_middle_name;
            phone = new_phone;
            agent_number = new_agent_number;
        }
    }

    class Announcement
    {
        int announcementID;
        int objectID;
        int agentID;
        DateTime published_at;
        string status;
        decimal rate;

        public Announcement(int new_announcementID, int new_objectID, int new_agentID, DateTime new_published_at, string new_status, decimal new_rate)
        {
            announcementID = new_announcementID;
            objectID = new_objectID;
            agentID = new_agentID;
            published_at = new_published_at;
            status = new_status;
            rate = new_rate;
        }
    }

    class Showing
    {
        int showingID;
        int announcementID;
        int agentID;
        int arendatorID;
        DateTime shown_at;
        string result;

        public Showing(int new_showingID, int new_announcementID, int new_agentID, int new_arendatorID, DateTime new_shown_at, string new_result)
        {
            showingID = new_showingID;
            announcementID = new_announcementID;
            agentID = new_agentID;
            arendatorID = new_arendatorID;
            shown_at = new_shown_at;
            result = new_result;
        }
    }

    class Participation
    {
        int participationID;
        int contractID;
        int sobstvennikID;
        int arendatorID;
        string role;

        public Participation(int new_participationID, int new_contractID, int new_sobstvennikID, int new_arendatorID, string new_role)
        {
            participationID = new_participationID;
            contractID = new_contractID;
            sobstvennikID = new_sobstvennikID;
            arendatorID = new_arendatorID;
            role = new_role;
        }
    }

    class Program
    {
        static void Main()
        {
            var obj1 = new obiectnedv(10, "ул. Набережная 99, д. 3, кв. 77", 2, 60, 5);
            var obj2 = new obiectnedv(11, "ул. Гагарина 88, д. 6, кв. 44", 1, 45, 3);

            var sobstvennik1 = new Sobstvennik(1, "Соколов", "Сергей", "Сергеевич", "+7-900-111-11-11", "4501 123456");
            var sobstvennik2 = new Sobstvennik(2, "Петрушкин", "Пётр", "Петрович", "+7-900-222-22-22", "4502 456123");

            var arendator1 = new Arendator(3, "Волков", "Виктор", "Викторович", "+7-900-323-23-23");

            var contract1 = new Contract(100, 10, "действует", new DateTime(2026, 12, 1), new DateTime(2027, 12, 31), 50000);

            var agent1 = new Agent(200, "Морозов", "Михаил", "Михайлович", "+7-900-434-34-34", "A-001");
            var ann1 = new Announcement(77, 10, 200, new DateTime(2025, 1, 1), "активно", 50000);
            var showing1 = new Showing(100, 77, 200, 3, new DateTime(2026, 9, 26, 12, 0, 0), "успешно");
            var part1 = new Participation(600, 100, 1, 0, "арендодатель");
            Console.ReadLine();
        }
    }
}