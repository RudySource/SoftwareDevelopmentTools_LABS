// See https://aka.ms/new-console-template for more information
//fix
namespace Laba_ISP233_RodionPylnev
{

    class dragon
    {
        public void Variant_A()
        {
            string str = @"
                            ~              ((     ))
            Кто не дышит, но живет     ===  \\_v_//  ===
                хоть не нужно — много    ====)_^_(====
              пьёт; и в жизни,           ===/ O O \===
              и в смерти тело как лед?   = | /_ _\ | =
                                        =   \/_ _\/   =
                                             \_ _/
                                             (o_o)
                                              VwV;";
            Console.WriteLine("\nВам нужно будет ответить на загадку дракона:\nДракон говорит:");
            Console.WriteLine(str);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string next = "--------------------";
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine($"Чётное");
            }
            else
            {
                Console.WriteLine($"Не чётное");
            }
            Console.WriteLine(next);
            
            string pass = Console.ReadLine();
            string check = Console.ReadLine();
            if (pass == check)
            {
                Console.WriteLine($"Верный пароль");
            }
            else
            {
                Console.WriteLine($"Не верный");
            }
            Console.WriteLine(next);
            
            int n = int.Parse(Console.ReadLine());
            int first = n / 1000;
            int second = (n / 100) % 10;
            int third = (n / 10) % 10;
            int four = n % 10;
            if (first + four == second - third)
            {
                Console.WriteLine("Да");
            }
            else
            {
               Console.WriteLine("НЕТ"); 
            }
            Console.WriteLine(next);
                
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine($"Доступ разрешён");
            }
            else
            {
                Console.WriteLine($"Доступ запрещён");
            }
            Console.WriteLine(next);

            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            if (x1 > x2)
            {
                Console.WriteLine(x2);
            }
            else if (x2 == x1)
            {
                Console.WriteLine("Равны");
            }
            else
            {
                Console.WriteLine(x1);
            }
            Console.WriteLine(next);
            
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string method = Console.ReadLine();
            switch (method)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
            }
            Console.WriteLine(next);

            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");  
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }
            Console.WriteLine(next);

            //8 ЗАДАНИЕ, КАК 6. СДЕЛАЛ РАНЕЕ. ДАЛЬШЕ ИДËТ 9 ЗАДАНИЕ ->

            int difficult = int.Parse(Console.ReadLine());
            switch (difficult)
            {
                case 1:
                    Console.WriteLine("Лёгкий");
                    break;
                case 2:
                    Console.WriteLine("Средний");
                    break;
                case 3:
                    Console.WriteLine("Сложный");
                    break;
            }
            Console.WriteLine(next);

            //namespace Program
            //     {
            // //Класс программы - запуск кода
            // internal class Program
            // {
            //     // Статик для хп
            //     private static int health = 100;
            //     //Мэин запуск
            //     static void Main(string[] args)
            //     {
            //         // Вывод начального состояния здоровья
            //         Console.WriteLine($"Здоровье персонажа: {health}");
            //         // Нанесение урона
            //         TakeDamage(30);
            //     }
            //     
            //     // Метод для нанесения урона персонажу
            //     static void TakeDamage(int damage)
            //     {   // Вычитание из хп - дамака
            //         health -= damage;
            //         //Вывод полученного урона - кол-во 
            //         Console.WriteLine($"Персонаж получил {damage} урона. Текущее здоровье: {health}.");
            //     }
            // }
            
            string persona = Console.ReadLine();
            switch (persona)
            {
                default:
                    Console.WriteLine("Лень было делать другие классы");
                    break;
                case "воин":
                    Console.WriteLine("ближ");
                    break;
                case "маг":
                    Console.WriteLine("дальник");
                    break;
                case "разбойник":
                    Console.WriteLine("дальний");
                    break;
                case "паладин":
                    Console.WriteLine("ближ");
                    break;
            }
            Console.WriteLine(next);
            
            int a_1 = int.Parse(Console.ReadLine());
            int a_2 = int.Parse(Console.ReadLine());
            int a_3 = int.Parse(Console.ReadLine());
            int[] checking = new int[] { a_1, a_2, a_3 };
            int summ = 0;
            for (int i = 0; i <= 2; i++)
            {
                if (checking[i] > 0)
                {
                    summ += checking[i];
                }
            }
            Console.WriteLine($"\nСумма положительных = {summ}");
            Console.WriteLine(next);
            
            Console.WriteLine("Вы — отважный искатель приключений, отправившийся в Темный Лабиринт,\nчтобы найти легендарного Dungeon Master’а. Вам предстоит пройти через несколько\nкомнат, каждая из которых может иметь свои опасности и сокровища.");
            Console.Write("Вы стоите перед первой дверью. Перед вами два пути:\nПуть А: Войти в комнату с огромным драконом.\nПуть B: Пойти по темному коридору.\nЧто выберешь? - ");
            string answer = Console.ReadLine().ToLower();
            if ((answer == "a") | (answer == "а"))
            {
                dragon dr;
                dr = new dragon();
                dr.Variant_A();
                Console.Write($"Ваш ответ = ");
                string fish = Console.ReadLine().ToLower();
                switch (fish)
                {
                    default: Console.WriteLine("ВАС ПОГЛАТИЛ ДРАКОНУС");
                        break;
                    case "рыба": Console.WriteLine("Дракон открыл дверь в след.комнату...");
                        break;
                }
            }
            else if ((answer == "в") | (answer == "b"))
            {
                Console.Write("\nВы прошли в тёмную комнату. \nПеред вами 2 двери.\nКакую выберите? - ");
                int door = int.Parse(Console.ReadLine());
                switch (door)
                {
                    default: Console.WriteLine("Вы умерли от страха");
                        break;
                    case 1: Console.WriteLine("ПОЗДРАВЛЯЮ!!! ВЫ НАШЛИ СОКРОВИЩА Dungeon Master’а. - 300$");
                        break;
                    case 2: Console.WriteLine("За ней — ловушка с ядовитыми шипами.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("WASTED");
            }
        }
    }
}