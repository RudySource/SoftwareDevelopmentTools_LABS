// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

namespace Laba_ISP233_RodionPylnev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massive = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            Console.WriteLine(massive[3]);
            var n = massive[4];
            Console.WriteLine(n);
            massive[0] = 77;
            Console.WriteLine(massive[0]);
            Console.WriteLine(massive.Length);
            Console.WriteLine(massive.Length - 4);
            Console.WriteLine(massive[^3]);
            foreach (int i in massive)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine(massive[i]);
            }
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = massive[i] * 2;
                Console.WriteLine(massive[i]);
            }
            int[,] matrix = {{1, 2, 3}, {4, 5, 6}};
            dynamic[,] dyn_matrix = {{1, 2, 3}, {4, 5, 6}};
            object[,] obj_matrix = {{1, 2, 3}, {4, 5, 6}}; // - ЛУЧШЕ ИСП ЕГО.
            int[] nine = [1, -2, 3, 4, 5, 6, -7, 8, 9];
            int count = 0;
            foreach (int i in nine)
            {
                if (i < 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Кол-Во отрицательных - {count}");
            int middle = nine.Length / 2;
            int temp;
            for (int i = 0; i <= middle; i++)
            {
                temp = nine[i];
                nine[i] = nine[nine.Length - i - 1];
                nine[nine.Length - i - 1] = temp;
            }

            foreach (int i in nine)
            {
                Console.WriteLine($"{i} \t");
            }
            int[] _nine = [1, -2, 3, 4, 5, 6, -7, 8, 9];
            int _temp;
            for (int i = 0; i < _nine.Length; i++)
            {
                for (int j = i + 1; j < _nine.Length; j++)
                {
                    if (_nine[i] > _nine[j])
                    {
                        _temp = _nine[i];
                        _nine[i] = _nine[j];
                        _nine[j] = _temp;
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < _nine.Length; i++)
            {
                Console.WriteLine(_nine[i]);
            }

            List<string> student = ["МАМА", "ПАПА", "c++ снова выдаёт ошибку"];
            var YourStudent = new List<string>(student);
            List<string> ez = new(10);
            Console.WriteLine(student[1]);
            YourStudent[1] = "ХЛЕБ";
            Console.WriteLine(YourStudent[1]);
            Console.WriteLine(student.Count);
            foreach (var i in student)
            {
                Console.WriteLine($"{i}");
            }
            List<string> _student = ["Билли", "Игорь", "Степан"];
            _student.Add("Van"); // добавление нового элемента в список
            _student.AddRange(["Антон", "Денис"]);
            _student.Insert(1, "Кирилл"); // вставляет элемент item в список по
            _student.InsertRange(1, ["Mike", "Kate"]); // вставляет коллекцию элементов начиная с индекса index
            _student.Insert(7, "Михаил"); // вставляет элемент item в список по индексу index
            foreach (var person in _student)
            {
                Console.WriteLine(person);
            }
            var people = new List<string> () { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
            people.RemoveAt(1); // удаляем второй элемент
            people.Remove("Tom"); // удаляем элемент "Tom"
            people.RemoveRange(1, 2);
            people.Clear();
            
            //====НИЖЕ ИДËТ ДЗ!!!====//

            // string next = "--------------------";
            // Console.WriteLine(next);
            // string[] items = {"sword", "shield", "potion", "sword", "potion", "potion"};
            // Console.WriteLine(next);
            //
            // int[] xp = { 10, 20, 15, 30, 25 };
            // int total = 0;
            // foreach (int i in xp)
            // {
            //     total += i;
            // }
            // Console.WriteLine($"Общее кол-во очков: {total}");
            // Console.WriteLine(next);
            //
            // int[] m = {1, 3, 7, 2, 5};
            // int max = m[0];
            // foreach (int i in m)
            // {
            //     if (i > max) max = i;
            // }
            // Console.WriteLine($"Max элемент: {m.Max()}, а так же можно с помощью цикла {max}");
            // Console.WriteLine(next);
            //
            // int[] mass = {1, 2, 3, 4, 5};
            // int yeah_count = 0;
            // int bruh_count = 0;
            // foreach (int i in mass)
            // {
            //     if (i % 2 == 0) yeah_count++;
            //     else bruh_count++;
            // }
            // Console.WriteLine($"Четных: {yeah_count}\nНечетных: {bruh_count}");
            // Console.WriteLine(next);
            //
            // int[] time = {120, 95, 110, 105, 100};
            // Console.WriteLine($"Самое быстрое время: {time.Min()} секунд"); // короче, как в прошлом задание по сути, но тут без цикла сделаю - ибо есть min.
            // Console.WriteLine(next);
            //
            // string[] type = {"win", "losse", "win", "win", "losse"};
            // int win = 0;
            // int losse = 0;
            // foreach (string i in type)
            // {
            //     if (i == "win") win++;
            //     else if (i == "losse") losse++;
            // }
            // Console.WriteLine($"{win} победы и {losse} поражения");
            // Console.WriteLine(next);
            //
            // int[] score = { 15, 20, 25, 30, 10 };
            // int sum = 0;
            // foreach (int i in score)
            // {
            //     sum += i;
            // }
            // double middle = (double)sum / score.Length;
            // Console.WriteLine($"Среднее кол-во очков: {middle} или с помощью метода {score.Average()}");
            // Console.WriteLine(next);
            //
            // List<string> inventory = ["Меч", "Ласточка", "Бомба", "Зелье Гром", "Ласточка"];
            //
            // for (int i = 0; i < inventory.Count; i++)
            // {
            //     if (inventory[i] == "Ласточка")
            //     {
            //         inventory[i] = "Кошка";
            //     }
            // }
            // Console.WriteLine($"После замены: [{string.Join(", ", inventory)}]"); // P.S Вывод этих тын дынов - списков короче в интернете посмотрел
            // Console.WriteLine(next);
            //
            // List<string> teammate = ["Garrus", "Tali", "Mordin", "Grunt", "Jack"];
            // List<string> role = ["Лидер команды", "Техник", "Биотик", "Солдат", "Поддержка"];
            //
            // for (int i = 0; i < teammate.Count; i++)
            // {
            //     Console.WriteLine($"{role[i]}: {teammate[i]}");
            // }

        }
    }
}

