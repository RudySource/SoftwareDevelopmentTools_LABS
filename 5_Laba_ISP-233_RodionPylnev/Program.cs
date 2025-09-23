// See https://aka.ms/new-console-template for more information

// Console.Write("Введите ваше имя: ");
// string name = Console.ReadLine();
// Console.WriteLine("Ваш язык: ");
// string lang = Console.ReadLine().ToLower();
// switch (lang)
// {
//     case "ru": SayHelloRu(); break;
//     case "gr": SayHelloGR(); break;
//     case "en": SayHelloEN(); break;
//     default: Console.WriteLine("Язык не найден"); break;
// }
// void SayHelloRu() => Console.WriteLine($"Привет {name}");
// void SayHelloGR() => Console.WriteLine($"Guten {name}");
// void SayHelloEN() => Console.WriteLine($"Hello {name}");

// void Print(string msg)
// {
//     Console.WriteLine(msg);
// }
//
// Print("Hello World!");
//
// void sum(int x, int y)
// {
//     Console.WriteLine($"{x+y}");
// }
// int x = int.Parse(Console.ReadLine());
// int y = int.Parse(Console.ReadLine());
// sum(x, y);


// void PrintPerson(string name = "NO DATA", int age = 12, string vuz = "no data")
// {
//     Console.WriteLine($"Name: {name}, Age: {age}, вуз: {vuz}");
// }
//
// PrintPerson(vuz: "ВФВОЛГУ", age: 18, name: "rudy");
// PrintPerson();

// string GetMessage() => "Hello, World!";
//
// int GetNumber()
// {
//     return 1;
// }
//
// var message = GetMessage();
// Console.WriteLine($"{message} \n{GetMessage()} \n{GetNumber()}");

// int number = Convert.ToInt32(Console.ReadLine());
//
// void Checkvalue(int number)
// {
//     if (number < 0)
//     {
//         Console.WriteLine("Отрицательное");
//         return;
//     }
//     Console.WriteLine("Положительное");
// }
// Checkvalue(number);

// void ShowWelcome()
// {
//     Console.WriteLine("Welcome to our weather program");
// }
//
// void ShowGoodbye()
// {
//     Console.WriteLine("Goodbye my dear");
// }
//
// string getweather()
// {
//     string[] weathers = ["Sunny", "Cold", "Rainy", "Dota 3 realeses"];
//     Random random = new();
//     int index = random.Next(weathers.Length);
//     return weathers[index];
// }
//
// ShowWelcome();
// Console.WriteLine($"Weather yesterday: {getweather()}");
// ShowGoodbye();

// int Factorial(int x)
// {
//     if (x == 1) return 1;
//     return x * Factorial(x - 1);
// }
//
// Console.WriteLine(Factorial(2));




//====НИЖЕ ИДËТ ДЗ!!!====//


//-----ТЕСТ-----
// 1. Ничего
// 2. void ShowWelcomeMessage()
// 3. Метод выполнится с значениями по умолчанию
// 4. void PrintNumber(int number)
// 5. PrintMessage('Hello, World!')   

// //-----2-ЗАДАНИЕ-----
string next = "--------------------";
// // Console.WriteLine(next);
// void GreetUser()
// {
//     Console.Write("Введите имя: ");
//     string name = Console.ReadLine();
//     Console.WriteLine(name);
// }
// GreetUser();
// Console.WriteLine(next);
//
// //-----3-ЗАДАНИЕ-----
// void sum(int x, int y)
// {
//     Console.WriteLine($"{x+y}");
// }
// Console.WriteLine("Введите числа для сложения:");
// int x = int.Parse(Console.ReadLine());
// int y = int.Parse(Console.ReadLine());
// sum(x, y);
// Console.WriteLine(next);
//
// //-----4-ЗАДАНИЕ-----
// bool isEven(int x)
// {
//     return (x % 2 == 0);
// }
// Console.Write("Введите число: ");
// Console.WriteLine(isEven(int.Parse(Console.ReadLine())));
// Console.WriteLine(next);

//-----5-ЗАДАНИЕ-----
// int FindMax(int[] x)
// {
//     return x.Max();
// }
//
// Console.WriteLine($"Max значение: {FindMax([10, 23, 13, 2, 9, 11, 4])}");
// Console.WriteLine(next);
//
// //-----6-ЗАДАНИЕ-----
// double ConvertCelsiusToFahrenhei(int celsius)
// {
//     return celsius * 9.5 + 32;
// }
// Console.WriteLine(ConvertCelsiusToFahrenhei(12));
// Console.WriteLine(next);
//
// //-----7-ЗАДАНИЕ-----
// static int CountVowels(string str) // ---- Вообщем я прошерстил инет и нашёл способ Contains - для проверки входят ли буквы в слово.
// {
//     string vowels = "aeiou";
//     int count = 0;
//
//     foreach (char i in str.ToLower())
//     {
//         if (vowels.Contains(i))
//             count++;
//     }
//     return count;
// }
// Console.Write("EN WORD: ");
// string word = Console.ReadLine();
// Console.WriteLine(CountVowels(word));
// Console.WriteLine(next);
//
// //-----8-ЗАДАНИЕ-----
// static string password(int n)
// {
//     string symbols = "abcde123456789";
//     Random random = new Random();
//     char[] password = new char[n];
//
//     for (int i = 0; i < n; i++)
//     {
//         password[i] = symbols[random.Next(symbols.Length)];
//     }
//
//     return new string(password);
// }
// Console.Write("Введите длину пароля: ");
// Console.WriteLine(password(int.Parse(Console.ReadLine())));
// Console.WriteLine(next);

//-----9-ЗАДАНИЕ-----
static bool CheckPalindrome(string input)
{

    string palindrome = input.ToLower();
    int left = 0;
    int right = palindrome.Length - 1;
    while (left < right)
    {
        if (palindrome[left] != palindrome[right])
        {
            return false;
        }
        left++;
        right--;
    }
    return true;
}
Console.Write("Введите палиндром: ");
Console.WriteLine(CheckPalindrome(Console.ReadLine()));
Console.WriteLine(next);

//-----10-ЗАДАНИЕ-----
static int[] ReverseArray(int[] mas)
{
    int[] reversed = new int[mas.Length];
    for (int i = 0; i < mas.Length; i++)
    {
        reversed[i] = mas[mas.Length - 1 - i];
    }
    return reversed;
}

int[] rev_mass = {1, 2, 3};
int[] edit_massive = ReverseArray(rev_mass);
foreach (int i in edit_massive)
{
    Console.Write($"{i} ");
}
Console.WriteLine("\n" + next);

//-----11-ЗАДАНИЕ-----

static void Calculate()
{
    while (true)
    {
        Console.Write(
            "Калькулятор\n1. Сложение\n2. Вычитание\n3. Умножение\n4. Деление\n5. Выход\nВыберите операцию: ");
        string variant = Console.ReadLine();
        double result = 0;
        double num1 = 0;
        double num2 = 0;

        if (variant == "5")
        {
            Console.WriteLine("Выход из программы...");
            return;
        }

        if (int.Parse(variant) < 5)
        {
            Console.Write("Введите первое число: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            num2 = double.Parse(Console.ReadLine());
            
        }
        else
        {
            Console.WriteLine("Error\n");
        }


        switch (variant)
        {
            case "1":
                result = plus(num1, num2);
                break;
            case "2":
                result = minus(num1, num2);
                break;
            case "3":
                result = multiply(num1, num2);
                break;
            case "4":
                result = division(num1, num2);
                break;
        }

        if (int.Parse(variant) < 5)
        {
            Console.WriteLine($"Результат: {result} \n");
        }
    }
}

static double plus(double num1, double num2) => num1 + num2;
static double minus(double num1, double num2) => num1 - num2;
static double division(double num1, double num2) => num1 / num2;
static double multiply(double num1, double num2) => num1 * num2;

Calculate();
Console.WriteLine(next);

//-----12-ЗАДАНИЕ-----
static bool IsPrime(int x)
{
    if (x < 1)
        return false;
    else if (x == 2)
        return true;
    else if (x % 2 == 0)
        return false;

    for (int i = 3; i * i <= x; i += 2)
    {
        if (x % i == 0)
            return false;
    }

    return true;
}

static void PrintPrimesUpTo(int n)
{
    Console.WriteLine($"Числа до {n}:");
    for (int i = 2; i <= n; i++)
    {
        if (IsPrime(i))
        {
            Console.Write($"{i} ");
        }
    }
}

Console.Write("Введите число: ");
PrintPrimesUpTo(int.Parse(Console.ReadLine()));

//try catch, new.exception - выучить, найти в интернете.