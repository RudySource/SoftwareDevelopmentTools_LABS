// See https://aka.ms/new-console-template for more information
using System;

namespace Laba_ISP233_RodionPylnev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favourite = "Titanfall2";
            int number = 999;
            double pi = Math.PI;
            string bukva = "Z";
            string next = "---------------------";
            Console.WriteLine($"Любимая игра - {favourite} \nЛюбимая цифра - {number} \nЧисло Pi - {pi} \nЛюбимая буква - {bukva} \n{next}");
            
            Console.WriteLine($"I need more power \nI need more power\nI need more power\nI need more power\n{next}");
            
            Console.WriteLine($"\"Hello There\" \n{next}");
            
            Console.Write("Моник - ");
            int monitor = int.Parse(Console.ReadLine());
            Console.Write("Системник - ");
            int computer = int.Parse(Console.ReadLine());
            Console.Write("Клава - ");
            int keyboard = int.Parse(Console.ReadLine());
            Console.Write("Мышь - ");
            int mouse = int.Parse(Console.ReadLine());
            Console.Write($"Общая стоимость - {monitor + keyboard + mouse + computer}\n{next}\n");
            
            Console.Write("a - ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b - ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{(3 * Math.Pow((a + b), 3)) + (275 * Math.Pow(b, 2)) - (127 * a) - 41} \n{next}");
            
            Console.Write("Ваше имя - ");
            string myname = Console.ReadLine();
            Console.Write("Ваш возраст - ");
            int myage = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ответ кода:\nВаше имя - {myname}\nВаш возраст - {myage}\nЧерез год вам будет - {myage +1}\n{next}");
            
            // 6 И 7 Задания связанны
            Console.Write("Ваш город - ");
            string mycity = Console.ReadLine();
            Console.WriteLine($"Привет, {myname}! Тебе {myage} лет и ты живёшь в городе {mycity}.\n{next}");
            
            Console.Write("Tемпература в °C - ");
            int tempu = int.Parse(Console.ReadLine());
            Console.WriteLine($"{tempu * 1.8f + 32}°F");
        }
    }
}
