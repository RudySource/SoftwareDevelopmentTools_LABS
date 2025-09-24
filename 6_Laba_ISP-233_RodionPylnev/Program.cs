// See https://aka.ms/new-console-template for more information
namespace Error;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            double result = 0;
            bool zero = false;
            try
            {
                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());
                Console.Write("Exit - Выход из программы\nВведите знак операции(+,-,*,/,^): ");
                string? znak = Console.ReadLine();
                if (znak == "exit")
                {
                    break;
                }
                switch (znak)
                {
                    case "+":
                        result = plus(num1, num2);
                        break;
                    case "-":
                        result = minus(num1, num2);
                        break;
                    case "*":
                        result = multiply(num1, num2);
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("Делить на 0 нельзя");
                        }
                        result = devide(num1, num2);
                        break;
                    case "^":
                        result = degree(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Error operation");
                        break;
                }
                static double plus(double a, double b) { return a + b; }
                static double minus(double a, double b) { return a - b; }
                static double multiply(double a, double b) { return a * b; }
                static double devide(double a, double b) { return a / b; }
                static double degree(double a, double b)
                {
                    double result = 1;
                    for (int i = 0; b > i; i++)
                    {
                        result *= a; 
                    } 
                    return result;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка ввода при дилении на 0: {ex.Message}\n");
                zero = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}");
            }
        
            if (zero != true)
            {
                Console.WriteLine($"Результат: {result}\n");
            }
        }
        
        //===== 4 ЗАДАНИЕ =====
        while (true)
        {
            Console.Write("Введите первое число: ");
            if (int.TryParse(Console.ReadLine(), out var num))
            {
                Console.WriteLine("Good");
                break;
            }
            else
            {
                Console.WriteLine("Не то форматирование");
            }
        }
    }
}
    