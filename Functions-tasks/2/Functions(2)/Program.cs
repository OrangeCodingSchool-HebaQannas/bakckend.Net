using System;

class Program
{
    static void Main()
    {
        //1
        DateOnly start = new DateOnly(2018, 12, 29);
        DateOnly end = new DateOnly(2019, 1, 1);

        int totalDays = getDays(start, end);

        Console.WriteLine("Days between: " + totalDays);

        //2
        string[] arr = ["1a", "a", "2b", "b"];
        Console.WriteLine($"the strings that have numbers: {string.Join(", ", numInString(arr))}");

        //3
        Console.WriteLine("reverse string with odd length: " + reverseOdd("Bananas"));
    }

    //1
    static int getDays(DateOnly d1, DateOnly d2)
    {
        return Math.Abs(d2.DayNumber - d1.DayNumber);
    }

    //2
    static string[] numInString(string[] arr)
    {
        return arr.Where(item => item.Any(char.IsDigit)).ToArray();
    }

    //3
    static string reverseOdd(string str) 
    {
        return string.Join(" ", str.Split(" ").Select(str => str.Length % 2 != 0 ? new string(str.Reverse().ToArray()) : str));

    }

}