using System;

class Program
{
    static void Main()
    {
        Console.Write(" ");
        int baseNumber = int.Parse(Console.ReadLine());

        Console.Write(" ");
        int power = int.Parse(Console.ReadLine());

        Console.WriteLine(" " + RaiseToPower(baseNumber, power));
    }

    static int RaiseToPower(int baseNumber, int power)
    {
        return (int)Math.Pow(baseNumber, power);
    }
}
