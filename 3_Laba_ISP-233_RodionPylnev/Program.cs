// See https://aka.ms/new-console-template for more information

namespace Laba_ISP233_RodionPylnev
{
    internal class Program
    { 
        enum TrafficLight { Red, Yellow, Green }
        enum OrderStatus { New, Processing, Shipped, Delivered }
        static void Main(string[] args)
        {
            string next = "--------------------";
            // Console.WriteLine(next);
            TrafficLight now = TrafficLight.Green;
            TrafficLight next_light;
            if (now == TrafficLight.Green)
            {
                next_light = TrafficLight.Red;
            }
            else if (now == TrafficLight.Yellow)
            {
                next_light = TrafficLight.Red;
            }
            else
            {
                next_light = TrafficLight.Yellow;
            }
            Console.WriteLine($"После: {now}, будет: {next_light}");
            Console.WriteLine(next);
    
            OrderStatus a = OrderStatus.New;
            OrderStatus b = OrderStatus.Shipped;
            static bool CancelOrder(OrderStatus status)
            {
                if (status == OrderStatus.New || status == OrderStatus.Shipped)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            Console.WriteLine($"Можно ли отменить заказ a? - {CancelOrder(a)}");
            Console.WriteLine($"Можно ли отменить заказ b? - {CancelOrder(b)}");
            Console.WriteLine(next);
            
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(next);
            
            int x = 5;
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{x} x {j} = {x * j}");
            }
            Console.WriteLine(next);
            
            string stethem = "Запомни: всего одна ошибка и ты ошибся.";
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(stethem);
            }
            Console.WriteLine(next);
            
            Console.Write("Введите n: ");
            int numer = int.Parse(Console.ReadLine());
            if (numer % 2 == 0)
            {
                for (int i = 0; i <= numer; i++)
                {
                    Console.WriteLine($"Квадрат числа {i} равен {i * i}");
                }
            }
            else
            {
                Console.WriteLine("Введите натуральное число.");
            }
            Console.WriteLine(next);
            
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();
            Console.Write("Введите кол-во повторений: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(sentence);
            }
            Console.WriteLine(next);
            
            Console.WriteLine("Введите 10 целых чисел:");
            bool yeah = true;
            for (int i = 0; i < 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 != 0)
                {
                    yeah = false;
                }
            }
    
            Console.WriteLine(yeah ? "YES" : "NO");
            Console.WriteLine(next);
            
            Console.WriteLine("Добро пожаловать на стрельбище!");
            int count = 0;
            while (true)
            {
                count++;
                Console.WriteLine("Выстрел совершен");
                Console.WriteLine($"Израсходовано боезапасов: {count}");
                Console.Write("Нажмите Enter: ");
                string input = Console.ReadLine();
                if (input != "")
                {
                    Console.WriteLine($"Израсходовано боезапасов: {count}");
                    break;
                }
                
            }
        }
    }
}

