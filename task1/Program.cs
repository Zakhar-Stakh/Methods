using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перше число:");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        double number2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть операцію (+, -, *, /):");
        char operation = Console.ReadLine()[0];

        double result = Calculate(number1, number2, operation);
        Console.WriteLine($"Результат: {result}");
    }

    static double Calculate(double number1, double number2, char operation)
    {
        switch (operation)
        {
            case '+':
                return number1 + number2; 
            case '-':
                return number1 - number2; 
            case '*':
                return number1 * number2; 
            case '/':
                if (number2 != 0)
                    return number1 / number2; 
                else
                    throw new DivideByZeroException("Помилка: Ділення на нуль!");
            default:
                throw new InvalidOperationException("Помилка: Невідома операція!");
        }
    }
}