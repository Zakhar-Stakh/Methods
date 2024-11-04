using System;

class GeometricCalculator
{
    static void Main()
    {
        Console.WriteLine("Виберіть геометричну фігуру для обчислення:");
        Console.WriteLine("1. Коло (площа)");
        Console.WriteLine("2. Прямокутник (площа)");
        Console.WriteLine("3. Куб (об'єм)");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CalculateCircleArea();
                break;
            case 2:
                CalculateRectangleArea();
                break;
            case 3:
                CalculateCubeVolume();
                break;
            default:
                Console.WriteLine("Неправильний вибір.");
                break;
        }
    }

    static void CalculateCircleArea()
    {
        Console.WriteLine("Введіть радіус кола:");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Площа кола: {area}");
    }

    static void CalculateRectangleArea()
    {
        Console.WriteLine("Введіть довжину прямокутника:");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть ширину прямокутника:");
        double width = double.Parse(Console.ReadLine());
        double area = length * width;
        Console.WriteLine($"Площа прямокутника: {area}");
    }

    static void CalculateCubeVolume()
    {
        Console.WriteLine("Введіть довжину сторони куба:");
        double side = double.Parse(Console.ReadLine());
        double volume = Math.Pow(side, 3);
        Console.WriteLine($"Об'єм куба: {volume}");
    }
}