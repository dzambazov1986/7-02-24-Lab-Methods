using System;

class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        if (type == "int")
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(firstInt, secondInt));
        }
        else if (type == "char")
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(firstChar, secondChar));
        }
        else if (type == "string")
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            Console.WriteLine(GetMax(firstString, secondString));
        }
    }

    static int GetMax(int first, int second)
    {
        return Math.Max(first, second);
    }

    static char GetMax(char first, char second)
    {
        return (char)GetMax((int)first, (int)second);
    }

    static string GetMax(string first, string second)
    {
        return first.CompareTo(second) > 0 ? first : second;
    }
}