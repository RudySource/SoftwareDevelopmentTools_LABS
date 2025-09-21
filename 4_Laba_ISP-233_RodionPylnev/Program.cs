// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

namespace Laba_ISP233_RodionPylnev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string next = "--------------------";
            // Console.WriteLine(next);
            string[] items = {"sword", "shield", "potion", "sword", "potion", "potion"};
            Console.WriteLine(next);
            
            int[] xp = { 10, 20, 15, 30, 25 };
            int total = 0;
            foreach (int i in xp)
            {
                total += i;
            }
            Console.WriteLine($"Общее кол-во очков: {total}");
            Console.WriteLine(next);
            
            int[] m = {1, 3, 7, 2, 5};
            int max = m[0];
            foreach (int i in m)
            {
                if (i > max) max = i;
            }
            Console.WriteLine($"Max элемент: {m.Max()}, а так же можно с помощью цикла {max}");
            Console.WriteLine(next);
            
            int[] mass = {1, 2, 3, 4, 5};
            int yeah_count = 0;
            int bruh_count = 0;
            foreach (int i in mass)
            {
                if (i % 2 == 0) yeah_count++;
                else bruh_count++;
            }
            Console.WriteLine($"Четных: {yeah_count}\nНечетных: {bruh_count}");
            Console.WriteLine(next);
            
            int[] time = {120, 95, 110, 105, 100};
            Console.WriteLine($"Самое быстрое время: {time.Min()} секунд"); // короче, как в прошлом задание по сути, но тут без цикла сделаю - ибо есть min.
            Console.WriteLine(next);
            
            string[] type = {"win", "losse", "win", "win", "losse"};
            int win = 0;
            int losse = 0;
            foreach (string i in type)
            {
                if (i == "win") win++;
                else if (i == "losse") losse++;
            }
            Console.WriteLine($"{win} победы и {losse} поражения");
            Console.WriteLine(next);
            
            int[] score = { 15, 20, 25, 30, 10 };
            int sum = 0;
            foreach (int i in score)
            {
                sum += i;
            }
            double middle = (double)sum / score.Length;
            Console.WriteLine($"Среднее кол-во очков: {middle} или с помощью метода {score.Average()}");
            Console.WriteLine(next);
            
            List<string> inventory = ["Меч", "Ласточка", "Бомба", "Зелье Гром", "Ласточка"];
            
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i] == "Ласточка")
                {
                    inventory[i] = "Кошка";
                }
            }
            Console.WriteLine($"После замены: [{string.Join(", ", inventory)}]"); // P.S Вывод этих тын дынов - списков короче в интернете посмотрел
            Console.WriteLine(next);
            
            List<string> teammate = ["Garrus", "Tali", "Mordin", "Grunt", "Jack"];
            List<string> role = ["Лидер команды", "Техник", "Биотик", "Солдат", "Поддержка"];
    
            for (int i = 0; i < teammate.Count; i++)
            {
                Console.WriteLine($"{role[i]}: {teammate[i]}");
            }
            
        }
    }
}

