using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        //1
        Console.WriteLine(Add(10)(20));

        //3
        int[] arr = [10, 40, 30, 20, 50];
        Console.WriteLine($"The second largest of the array {string.Join(", ", arr)} is: {secondLargest(arr)}");

        //5
        string words = "a good example";
        Console.WriteLine($"The reverse of the array {words} is: {reverseWords(words)}");

        //6
        int[] nums = [1, 2, 3, 4, 5, 6, 7];
        Console.WriteLine($"If the array {string.Join(", ", nums)} has a 7 the output will be Boom: {sevenBoom(nums)}");

        //7
        Console.WriteLine(insertWhiteSpace("SheWalksToTheBeach"));

        //8
        Console.WriteLine(countTrue([true, false, false, true, false]));

        //9
        Console.WriteLine(capToFront("hApPy"));

        //11
        double[] numbers = [double.NaN, 1, 2, 3, 4];
        Console.WriteLine(findNaN(numbers));

        //14
        Console.WriteLine(removeLastVowel("Those who dare to fail miserably can achieve greatly."));

        //15
        Console.WriteLine(sumOfCubes([1, 5, 9]));
    }

    //1
    static Func<int, int> Add(int n)
    {
        return x => x + n;
    }

    //3
    static int secondLargest(int[] arr)
    {
        Array.Sort(arr);
        return arr[arr.Length - 2];
    }

    //5
    static string reverseWords(string str)
    {
        string[] words = str.Trim().Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }

    //6
    static string sevenBoom(int[] arr)
    {
        string result = "";
        foreach (int i in arr)
        {
            if (i == 7)
            {
                result = "Boom!";
            }
            else
            {
                result = "There's no 7 in the array";
            }
        }
        return result;
    }

    //7
    static string insertWhiteSpace(string str)
    {
        return Regex.Replace(str, @"(?<=[a-z])(?=[A-Z])", " ");
    }

    //8
    static int countTrue(bool[] arr)
    {
        return arr.Count(x => x==true);
    }

    //9
    static string capToFront(string str)
    {
        var caps = str.Where(char.IsUpper);
        var lows = str.Where(char.IsLower);

        return new string(caps.Concat(lows).ToArray());
    }

    //11
    static int findNaN(double[] arr)
    {
        return Array.FindIndex(arr,double.IsNaN);
    }

   //14
   static string removeLastVowel(string str)
    {
        string[] words = str.Split(" ");
        string vowels = "aioueAIOUE";

        for (int i = 0; i < words.Length; i++)
        {
            int lastVowelIndex = words[i].LastIndexOfAny(vowels.ToCharArray());
            if(lastVowelIndex != -1)
            {
                words[i] = words[i].Remove(lastVowelIndex, 1);
            }
        }

        return string.Join(" ", words);
    }

    static int sumOfCubes(int[] arr)
    {
        return arr.Sum(n => n * n * n);
    }
}
