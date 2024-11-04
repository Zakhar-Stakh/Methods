using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть елементи масиву через пробіл:");
        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        (int min, int max) = FindMinAndMax(array);

        Console.WriteLine($"Найменший елемент: {min}");
        Console.WriteLine($"Найбільший елемент: {max}");
    }

    static (int min, int max) FindMinAndMax(int[] array)
    {
        if (array.Length == 0)
            throw new ArgumentException("Масив не може бути порожнім.");

        int min = array[0];
        int max = array[0];

        foreach (int num in array)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        return (min, max);
    }
}