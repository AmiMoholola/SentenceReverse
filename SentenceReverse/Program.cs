using System;
using System.Collections.Generic;
public class Program
{
    static void Main()
    {
        if (int.TryParse(Console.ReadLine(), out int cases))
        {
            List<string> lines = ReadLines(cases);

            if (lines.Count == cases)
            {
                for (int i = 0; i < cases; i++)
                {
                    string reversed = ReverseWords(lines[i]);
                    Console.WriteLine($"Case {i + 1}: {reversed}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Exiting.");
            }
        }
        else
        {
            Console.WriteLine("Invalid number of cases.");
        }
    }
    public static List<string> ReadLines(int cases)
    {
        List<string> lines = new List<string>();

        for (int i = 0; i < cases; i++)
        {
            string? line = Console.ReadLine();
            if (IsValidLine(line!))
            {
                lines.Add(line!);
            }
            else
            {
                Console.WriteLine($"Invalid input for Case {i + 1}. The length of the line must be between 1 and 25 Characters.");
                return new List<string>();
            }
        }

        return lines;
    }

    public static bool IsValidLine(string line)
    {
        return line != null && line.Length >= 1 && line.Length <= 25;
    }

    public static string ReverseWords(string input)
    {
        if (input == null)
        {
            return string.Empty;
        }

        string[] words = input.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }

}

