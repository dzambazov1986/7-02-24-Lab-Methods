using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMultipleOfEvenAndOdds(number));
    }

    static int GetMultipleOfEvenAndOdds(int number)
    {
        return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
    }

    static int GetSumOfEvenDigits(int number)
    {
        int sum = 0;
        foreach (char digit in Math.Abs(number).ToString())
        {
            int num = int.Parse(digit.ToString());
            if (num % 2 == 0)
            {
                sum += num;
            }
        }
        return sum;
    }

    static int GetSumOfOddDigits(int number)
    {
        int sum = 0;
        foreach (char digit in Math.Abs(number).ToString())
        {
            int num = int.Parse(digit.ToString());
            if (num % 2 != 0)
            {
                sum += num;
            }
        }
        return sum;
    }
}