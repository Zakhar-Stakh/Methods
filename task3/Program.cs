using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.WriteLine("Введіть суму для конвертації:");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Введіть обмінний курс (наприклад, кількість одиниць цільової валюти за 1 одиницю початкової валюти):");
        decimal exchangeRate = decimal.Parse(Console.ReadLine());

        decimal convertedAmount = ConvertCurrency(amount, exchangeRate);
        Console.WriteLine($"Конвертована сума: {convertedAmount}");
    }

    static decimal ConvertCurrency(decimal amount, decimal exchangeRate)
    {
        return amount * exchangeRate;
    }
}