using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть рядок:");
        string input = Console.ReadLine();

        (int vowelsCount, int consonantsCount) = CountVowelsAndConsonants(input);

        Console.WriteLine($"Кількість голосних: {vowelsCount}");
        Console.WriteLine($"Кількість приголосних: {consonantsCount}");
    }

    static (int vowels, int consonants) CountVowelsAndConsonants(string input)
    {
        int vowels = 0;
        int consonants = 0;

        string vowelsSet = "AEIOUYaeiouy";

        foreach (char c in input)
        {
            if (char.IsLetter(c)) 
            {
                if (vowelsSet.Contains(c))
                {
                    vowels++; 
                }
                else
                {
                    consonants++; 
                }
            }
        }

        return (vowels, consonants);
    }
}