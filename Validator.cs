using System;

class Validator
{
    public int ReadInt(string prompt)
    {
        Console.Write(prompt);
        string? s = Console.ReadLine();
        int x = 0;
        while (!int.TryParse(s, out x))
        {
            Console.WriteLine(
                "Пожалуйста, вводите только цифры");
            Console.WriteLine();
            Console.Write(prompt);
            s = Console.ReadLine();
        }
        return x;
    }

    public int? ReadNullableInt(string prompt)
    {
        Console.Write(prompt);
        string? s = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(s))
        {
            return null;
        }

        int x;
        while (!int.TryParse(s, out x) || x < 0)
        {
            Console.WriteLine(
                "Введите целое число >= 0 или Enter");
            Console.Write(prompt);
            s = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(s))
            {
                return null;
            }
        }
        return x;
    }

    public int ReadPositiveInt(string prompt)
    {
        int x;
        do
        {
            x = ReadInt(prompt);
            if (x <= 0)
            {
                Console.WriteLine("Число должно быть > 0");
            }
        } while (x <= 0);
        return x;
    }

    public int ReadNonNegativeInt(string prompt)
    {
        int x;
        do
        {
            x = ReadInt(prompt);
            if (x < 0)
            {
                Console.WriteLine("Число должно быть >= 0");
            }
        } while (x < 0);
        return x;
    }

    public string ReadName(string prompt)
    {
        Console.Write(prompt);
        string? s = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(s)
            || !IsLettersOnly(s))
        {
            Console.WriteLine(
                "Пожалуйста, вводите только буквы, " +
                "дефис или пробелы");
            Console.Write(prompt);
            s = Console.ReadLine();
        }
        return s;
    }

    public string? ReadNullableName(string prompt)
    {
        Console.Write(prompt);
        string? s = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(s))
        {
            return null;
        }

        while (!IsLettersOnly(s))
        {
            Console.WriteLine(
                "Пожалуйста, вводите только буквы, " +
                "дефис или пробелы");
            Console.Write(prompt);
            s = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(s))
            {
                return null;
            }
        }

        return s;
    }

    public static bool IsLettersOnly(string s)
    {
        bool hasLetter = false;
        foreach (char c in s)
        {
            if (char.IsLetter(c))
                hasLetter = true;
            else if (c != ' ' && c != '-')
                return false;
        }
        return hasLetter;
    }
}
