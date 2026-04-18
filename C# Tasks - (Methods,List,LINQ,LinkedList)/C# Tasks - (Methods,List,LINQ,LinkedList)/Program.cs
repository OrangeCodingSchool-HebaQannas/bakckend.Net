using System;
using System.Collections;
class Program
{
    static void Main()
    {
        //Task 1
        //  List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        //// Using LINQ to filter even numbers
        //var evenNumbers = numbers.Where(n => n % 2 == 0);
        //Console.WriteLine($"The list: {string.Join(", ", numbers)}");
        //Console.WriteLine("Even numbers:");
        //foreach (var num in evenNumbers)
        //{
        //    Console.Write(num);
        //}

        //Task 2
        //List<int> numbers = new List<int> { 1, 2, 3, 3, 2 };

        //var noDuplicates = numbers.Distinct();
        //Console.WriteLine($"The list: {string.Join(", ", numbers)}");
        //Console.Write("The list without duplicates:");
        //foreach (var num in noDuplicates)
        //{
        //    Console.Write(num+" ");
        //}

        //task 3
        //List<int> numbers = new List<int> { 1, 4, 6, 4, 2, 73, 45 };
        ////Using LINQ find the max
        //var max = numbers.Max();
        //Console.WriteLine($"The list: {string.Join(", ", numbers)}");
        //Console.WriteLine($"The max number is: {max}");

        //Task 4
        //List<int> numbers = new List<int> { 1,2,3,4,5,6 };
        //Console.WriteLine($"The List before reversing: {string.Join(", ", numbers)}");
        ////using list.revervse() to reverse the list
        //numbers.Reverse();

        //Console.WriteLine($"The list after reversing: {string.Join(", ", numbers)}");

        //Task 5
        //List<int> numbers = new List<int> { 34, 45, 56, 87, 23, 12, 9 };

        //var count = numbers.Count(n => n > 50);
        //Console.WriteLine($"The list: {string.Join(", ", numbers)}");
        //Console.WriteLine($"Numbers greater than 50: {count}");

        //Dictionary
        //Task 6
        //Dictionary<string, int> scores = new Dictionary<string, int>
        //{
        //    { "Ali", 90 },
        //    { "Sara", 85 },
        //    { "John", 78 }
        //};

        //// Using LINQ to print students with scores greater than 80
        //var result = scores.Where(s => s.Value > 80);
        //Console.WriteLine($"The scores: {string.Join(", ", scores.Select(s => $"{s.Key}: {s.Value}"))}");
        //Console.WriteLine("Students with scores greater than 80:");
        //foreach (var student in result)
        //{
        //    Console.WriteLine($"{student.Key}: {student.Value}");
        //}

        ////Task 7
        //Console.WriteLine("Enter a name to seach for the score:");
        //string name = Console.ReadLine();

        //if (scores.ContainsKey(name))
        //{
        //    int score = scores[name];
        //    Console.WriteLine($"{name}'s score is: {score}");
        //}
        //else
        //{
        //    Console.WriteLine($"No reult not found for {name}");
        //}

        ////Task 8
        //Console.Write("The total of the scores is: ");
        //int total = scores.Values.Sum();
        //Console.WriteLine(total);

        ////Task 9
        //scores.Add("Lina", 42);
        //scores.Add("Omar", 67);
        //scores.Add("Nour", 39);
        //Console.WriteLine($"The scores after adding new students: {string.Join(", ", scores.Select(s => $"{s.Key}: {s.Value}"))}");

        //var keyToRemove = scores.Where(s=> s.Value < 50).Select(s => s.Key).ToList();

        //foreach(var key in keyToRemove)
        //{
        //    scores.Remove(key);
        //}

        //Console.WriteLine($"The scores after removing students with scores less than 50: {string.Join(", ", scores.Select(s => $"{s.Key}: {s.Value}"))}");

        ////Task 10
        //Console.Write("The student with highest score: ");
        //var highestScore = scores.OrderByDescending(s => s.Value).FirstOrDefault().Key;
        //Console.WriteLine(highestScore);

        // LinkedList
        //Task 11
        //LinkedList<string> list = new LinkedList<string>();

        //list.AddLast("Ali");
        //list.AddLast("Sara");
        //list.AddFirst("Jane");
        //list.AddLast("Lina");
        //list.AddFirst("Omar");
        //Console.WriteLine($"The linked list: {string.Join(", ", list)}");

        //int middleIndex = list.Count / 2;
        //LinkedListNode<string>? currentNode = list.First;
        //for (int i = 0; i < middleIndex; i++)
        //{
        //    currentNode = currentNode.Next;
        //}

        //list.Remove(currentNode);
        //Console.WriteLine($"The linked list after removing the middle element: {string.Join(", ", list)}");


        ////Task 13
        //LinkedListNode<string> targetNode = list.Find("Omar");
        //if (targetNode != null)
        //{
        //    list.AddAfter(targetNode, "Nour");
        //    list.AddBefore(targetNode, "Dina");
        //}

        //Console.WriteLine($"The list after insertion : {string.Join(", ", list)}");

        ////Task 14
        //Console.WriteLine("The linked list printed using foreach loop:");
        //foreach(var item in list)
        //{
        //    Console.WriteLine(item);
        //}

        ////Task 15
        //Console.Write("The first element in the linked list: ");
        //Console.WriteLine(list.First.Value);
        //Console.WriteLine("The last element in the linked list: ");
        //Console.WriteLine(list.Last.Value);

        //LINQ
        //task 16

        //List<int> numbers = new List<int> { 45, 78, 2, 4, 1, 66, 4, 2, 3, 87, 15, 21, 17 };

        //var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
        //Console.WriteLine($"The list: {string.Join(", ", numbers)}");
        //Console.WriteLine($"The odd number in the list: {string.Join(", ", oddNumbers)}");

        ////Task 17
        //var mutiplyByTwo = numbers.Select(n => n * 2).ToList();
        //Console.WriteLine($"The number of the list after multiplying by 2: {string.Join(", ", mutiplyByTwo)}");

        ////Task 18
        //var sortedNumbers = numbers.OrderByDescending(n => n).ToList();
        //Console.WriteLine($"The list after sorting in descending order: {string.Join(", ", sortedNumbers)}");

        ////Task 19
        //numbers.Add(500);
        //numbers.Add(1000);
        //Console.WriteLine($"The list: {string.Join(", ", numbers)}");
        //Console.Write("The first number greater than 100 in the list: ");
        //var firstGreaterThan100 = numbers.FirstOrDefault(n => n > 100);
        //Console.WriteLine(firstGreaterThan100);

        ////Task 20
        //var average = numbers.Average();
        //Console.WriteLine($"The average of the numbers in the list: {average}");

        //Mixed tasks

        //Task 21
        //List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        //List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

        //var commonElements = list1.Intersect(list2);
        //Console.WriteLine($"List 1: {string.Join(", ", list1)}");
        //Console.WriteLine($"List 2: {string.Join(", ", list2)}");
        //Console.WriteLine($"Common elements between list 1 and list 2: {string.Join(", ", commonElements)}");

        //Task 22
        //var mergedlists = list1.Concat(list2);
        //Console.WriteLine($"Merged lists: {string.Join(", ", mergedlists)}");

        //Task 23
        //var uniquelists = mergedlists.Distinct().ToList();
        //Console.WriteLine($"Only unique elements in the merged lists {string.Join(", ", uniquelists)}");

        //Task 24
        //Dictionary<string, int> scores = new Dictionary<string, int>()
        //{
        //        { "Ali", 90 },
        //        { "Sara", 185 },
        //        { "Jane", 62 }
        //};
        //List<int> allScores = scores.Values.ToList();
        //Console.WriteLine($"Extacted scores: {string.Join(", ", allScores)}");

        ////Task 25
        //var filteredValues = scores.Where(s => s.Value > 100);
        //Console.WriteLine($"Filtered Scores greater than 100: {string.Join(", ",filteredValues)}");

        //Thinking tasks

        //Task 26
        List<int> numbers = new List<int> { 10, 25, 40, 21, 54, 74 };
        int target = 21;
        bool found = false;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == target)
            {
                found = true;
                Console.WriteLine($"Found {target} at index {i}");
                break;
            }
            
        }
        if (!found)
        {
            Console.WriteLine($"{target} is not found!");
        }


        //Task 27
        int evenCount = 0;
        foreach (int n in numbers)
        {
            if (n % 2 == 0)
            {
                evenCount++;
            }
        }
        Console.WriteLine($"Total even numbers: {evenCount}");

        //Task 28
        List<int> list = new List<int> { 10, 20, 30, 29, 32 };

        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (list[i] >25)
            {
                list.RemoveAt(i);
            }
        }
        Console.WriteLine($"List after removals: {string.Join(", ", list)}");

        //Task 29
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach(int n in list)
        {
            if(n> largest)
            {
                secondLargest = largest;
                largest = n;
            }
            else if (n > secondLargest && n != largest)
            {
                secondLargest = n;
            }
        }

        Console.WriteLine($"The second largest number in the list is: {secondLargest}, and the largest number is: {largest}");

        //Advanced logic tasks
        //.\\
    }
}