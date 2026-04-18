using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Transactions;

class Program
{
    static void Main()
    {
        //1
        Console.WriteLine("1.Convert 50 minutes into seconds: " + ConvertMinutesToSeconds(50));

        //2
        Console.WriteLine("2.Adding one to 4 to become 5: " + IncrementByOne(4));

        //3
        Console.WriteLine("3.First Elment of the array {5,6,1,2} is: " + FirstElement([5, 6, 1, 2]));

        //4
        Console.WriteLine("4.Triangle Area: " + TriangleArea(2, 3));

        //5
        var result5 = evenNumberEvenIndex(new int[] { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 });
        Console.WriteLine("5.Even number in even index: [" + string.Join(", ", result5) + "]");
        //6
        string[] result6 = evenIndexOddLength(new string[] { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" });
        Console.WriteLine("Odd length strings at even indices: [" + string.Join(", ", result6) + "]");

        //7
        double[] result7 = powerElementIndex(new int[] { 44, 5, 4, 3, 2, 10 });
        Console.WriteLine("Elements powered by their index: [" + string.Join(", ", result7) + "]");

        //8
        Console.WriteLine("8.takes two parameters and return the multiplication of them using only sum: " + multiplication2(2,8));

        //9
        Console.WriteLine("9.take two parameter and will return the multiplication from the first number to the second number: "+ multi2(3,6));

        //10
        Console.WriteLine("10.Avg of array: "+ aveArray([1, 2, 3, 8, 9]));

        
    }

    //1
    static double ConvertMinutesToSeconds(double minutes)
    {
        return minutes * 60;
    }

    //2
    static int IncrementByOne(int value)
    {
        return value + 1;
    }

    //3
    static int FirstElement(int[] arr)
    {
        return arr[0];
    }

    //4
    static double TriangleArea(double tribase, double height)
    {
        return 0.5 * tribase * height;
    }

    //5
    static int[] evenNumberEvenIndex(int[] arr)
    {
        return arr.Where((num, i) => num % 2 == 0 && i % 2 == 0).ToArray();
    }

    //6
    static string[] evenIndexOddLength(string[] arr)
    {
        return arr.Where((word,i)=> word.Length % 2 !=0 && i % 2 ==0).ToArray();
    }

    //7
    static double[] powerElementIndex(int[] arr)
    {
        return arr.Select((num, i) => Math.Pow(num, i)).ToArray(); 
    }

    //8
    static int multiplication2 (int a , int b)
    {
        int result = 0;

        for (int i = 0; i < b; i++)
        {
            result += a;
        }
        return result;
    }

    //9
    static int multi2 (int a , int b)
    {
        int result = a;
        for (int i =a+1; i<=b; i++)
        {
            result *= i;
        }
        return result;
    }

    //10
    static double aveArray (int[] arr)
    {
        double sum =0;

        for(int i = 0; i<arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum / arr.Length;
    }

}