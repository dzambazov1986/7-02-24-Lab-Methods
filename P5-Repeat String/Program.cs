using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        int repeatCount = int.Parse(Console.ReadLine());
        string result = RepeatString(text, repeatCount);
        Console.WriteLine(result);
    }

    static string RepeatString(string text, int repeatCount)
    {
        string result = "";
        for (int i = 0; i < repeatCount; i++)
        {
            result += text;
        }
        return result.Replace(" ", "");
    }
}