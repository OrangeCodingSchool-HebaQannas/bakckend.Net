using System;
using System.Collections;
using System.Linq;

class Program
{
    static void Main()
    {
        //Task 1

        //Console.WriteLine("Enter three numbers to calculate their average :");
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int c = Convert.ToInt32(Console.ReadLine());

        //double average = CalculateAverage(a, b, c);

        //Console.WriteLine("The average of the three numbers is: " + average);

        //----------------------

        //Task 2

        //List<string> names = new List<string>();

        //names.Add("Alice");
        //names.Add("Bob");
        //names.Add("Charlie");
        //names.Add("David");
        //names.Add("Eve");

        //Console.WriteLine("Names in the list:");
        //foreach (var n in names)
        //{
        //    Console.WriteLine(n);
        //}

        //names.Remove("Charlie");

        //-----------------------

        //Task 3

        //Dictionary<int, string> users = new Dictionary<int, string>();

        //users.Add(1, "Alice");
        //users.Add(2, "Bob");
        //users.Add(3, "Charlie");

        //foreach (var n in users)
        //{
        //    Console.WriteLine(n.Key + " - " + n.Value);
        //}

        //Task 4

        //int[] numbers = { 5, 10, 15, 20, 25, 30 };
        //string[] names = { "Ahmad", "Ali", "Sara", "Mona", "Omar", };

        ////1
        //var result = numbers.Where(n => n > 15);

        //foreach (var n in result)
        //{
        //    Console.WriteLine("The numbers greater than 15 is: " + n + " ");
        //}

        ////2
        //var evenNumbers = numbers.Where(n => n % 2 == 0);
        //foreach (var n in evenNumbers)
        //{
        //    Console.WriteLine("The Even numbers in the array are: " + n + " ");
        //}

        ////3
        //var orderAcending = names.OrderBy(n => n);
        //foreach (var n in orderAcending)
        //{
        //    Console.WriteLine("The numbers array ordered in Acending: " + n + " ");
        //}

        //var orderDescending = names.OrderByDescending(n => n);
        //foreach (var n in orderDescending)
        //{
        //    Console.WriteLine("The numbers array ordered in Descending: " + n + " ");
        //}

        ////4
        //var firstLetterWithA = names.Where(names => names.StartsWith("A"));
        //foreach (var n in firstLetterWithA)
        //{
        //    Console.WriteLine("The names starting with A are: " + n + " ");
        //}

        ////5
        //var firstNumGreaterThan10 = numbers.FirstOrDefault(n => n > 20);
        //Console.WriteLine(firstNumGreaterThan10);

        PrintWelcomeMessage();

        Console.WriteLine(printUserGreeting("Heba"));

        PrintAge(); 

        Console.WriteLine("The sum of 5 and 10 is: "+ calculateSumOfTwo(5, 10));

        int[] arr = { 1, 2, 3, 4, 5 };
        PrintArray(arr);
    }

    static double CalculateAverage(int a, int b, int c)
    {
        double sum = a + b + c;
        double average = sum / 3;

        return average;
    }

    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome!");
    }

    static string printUserGreeting(string name)
    {
        Console.WriteLine("Enter your name:");

        name = Console.ReadLine();
        return "Hello, " + name + "!";
    }

    static void PrintAge(int age = 22)
    {
        Console.WriteLine("Your age is: " + age);
    }

    static int calculateSumOfTwo(int a, int b)
    {
        return a + b;
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine("The elements in the array are:");
        foreach (var n in arr)
        {
            Console.WriteLine(n);
        }
    }

}