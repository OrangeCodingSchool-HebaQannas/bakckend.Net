using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {

        //Task 1
        //Console.WriteLine("Enter a number:");
        //int n = Convert.ToInt32(Console.ReadLine());
        //for (int i = 1; i<=n; i++)
        //{
        //    if (i%2==0)
        //        {
        //        for (int j = i; j >=1; j--)  
        //            Console.Write(j);
        //        }
        //        else
        //        {
        //        for (int j =1; j<=i; j++)
        //            Console.Write(j);
        //    }
        //    Console.WriteLine();

        //}

        //task 2
        //Console.WriteLine("Enter a number:");
        //int row = Convert.ToInt32(Console.ReadLine());

        //for (int i = 1; i <= row; i++)
        //{
        //    for (int j =1; j<=i; j++)
        //    {
        //        Console.Write(j);
        //    }

        //    for (int j =1; j<=(row-i) *2; j++)
        //    {
        //        Console.Write(" ");
        //    }

        //    for  ( int j=i; j>=1; j--)
        //    {
        //        Console.Write(j);
        //    }
        //    Console.WriteLine();
        //}

        //Task 3
        //Console.WriteLine("Enter a number:");
        //int n = Convert.ToInt32(Console.ReadLine());

        //for ( int i =1; i<=n; i++)
        //{
        //    for(int j =1; j<=n-i; j++)
        //    {
        //        Console.Write(" ");
        //    }

        //    for (int j =1; j<=i; j++)
        //    {
        //        Console.Write(j);
        //    }

        //    for (int j =i-1; j>=1; j--)
        //    {
        //        Console.Write(j);
        //    }

        //    Console.WriteLine();
        //}

        //Task 4

        //Console.WriteLine("Enter a number:");
        //int n = Convert.ToInt32(Console.ReadLine());

        //for (int i =1; i<=n; i++)
        //{
        //    int maxOdd = 2 * i - 1;
        //    for (int j =1; j<=maxOdd; j+=2)
        //    {
        //            Console.Write(j);

        //    }
        //    Console.WriteLine();

        //}

        //Task 5
        //Console.WriteLine("Enter a number:");
        //int n = Convert.ToInt32(Console.ReadLine());

        //int currentValue = 1;
        //for (int i =1; i<=n; i++)
        //{
        //    int sum = 0;
        //    for (int j =1; j<=i; j++)
        //    {
        //        Console.Write(currentValue + " ");
        //        sum += currentValue;
        //    }
        //    currentValue += 1;
        //    Console.WriteLine();
        //}

        ///////////////////////
        ///

        //Arrays 

        //Task 3
        //int[] arr = { 1, 1, 2, 2, 3, 1 };

        //Console.Write("intput: ");
        //Console.WriteLine(string.Join(", ", arr));

        //Console.WriteLine("Output: ");

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write(arr[i]);

        //    if (i== arr.Length - 1 || arr[i] != arr[i+1])
        //    {
        //        Console.Write("  ");
        //    }
        //}

        //Task 6
        //int[] arr = { 1, 2, 3, 2, 4 };

        //int windowSize = int.MaxValue;
        //int start = -1;
        //int end = -1;
        //for (int i =0; i<arr.Length; i++)
        //{
        //    for (int j = i+1; j<arr.Length; j++)
        //    {
        //        if(arr[i] == arr[j])
        //        {
        //            int currentWindowSize = j - i + 1;

        //            if (currentWindowSize < windowSize)
        //            {
        //                windowSize = currentWindowSize;
        //                start = i;
        //                end = j;
        //            }
        //        }
        //    }
        //}
        //if(start != -1)
        //{
        //    Console.Write("Smallest Duplicate Window: [");
        //    for (int j = start; j<=end; j++)
        //    {
        //        Console.Write(arr[j] + (j == end ? "" : ","));
        //    }
        //    Console.WriteLine("]");
        //}

        //task 7
        //int[] arr = { 5, 7, 10 };
        //int[] newArr = new int[arr.Length];
        //newArr[0] = arr[0];

        //for (int  i = 1;  i < arr.Length;  i++)
        //{
        //    newArr[i]= arr[i] - arr[i-1];
        //}

        //Console.WriteLine("Input: " + string.Join(", ", arr));
        //Console.WriteLine("Output: " + string.Join(", ", newArr));


        //task 8
        //int[] arr = {1,-2,3,-4,5};

        //List<int> pos = new List<int>();
        //List<int> neg = new List<int>();

        //foreach(int num in arr)
        //{
        //    if (num >= 0) pos.Add(num);
        //    else neg.Add(num);  
        //}

        //int p = 0, n = 0;
        //List<int> result = new List<int>();

        //while (p < pos.Count || n < neg.Count)
        //{
        //    if (p < pos.Count)
        //    {
        //        result.Add(pos[p]);
        //        p++;
        //    }
        //    if (n < neg.Count)
        //    {
        //        result.Add(neg[n]);
        //        n++;
        //    }
        //}

        //Console.WriteLine("Input: " + string.Join(", ", arr));
        //Console.WriteLine("Output: " + string.Join(", ", result));

        //Task 9
        //int[] arr = { 1, 2, 5, 3 };
        //int totalSum = 0;
        //int leftSum = 0;

        //foreach (int num in arr)
        //    totalSum += num;

        //for (int i =0; i<arr.Length; i++)
        //{
        //    int rightSum = totalSum - leftSum - arr[i];
        //    if(leftSum == rightSum)
        //    {
        //        Console.WriteLine($"Balace Point found at index {i} with value {arr[i]}");
        //        return;
        //    }
        //    leftSum += arr[i];
        //}
        //Console.WriteLine("No balace point found");

        //Strings

        //task 5
        //string input ="a-bC-dEf-ghIj";
        //char[] arr = input.ToCharArray();
        //int left = 0;
        //int right = arr.Length- 1;

        //while(left < right)
        //{
        //    if (!char.IsLetter(arr[left]))
        //    {
        //        left++;
        //    }
        //    else if (!char.IsLetter(arr[right])) 
        //    {
        //        right--;
        //    }
        //    //If both are letters, swap them
        //    else
        //    {
        //        char temp = arr[left];
        //        arr[left]= arr[right];
        //        arr[right] = temp;
        //        left++;
        //        right--;
        //    }
        //}
        //string output = new string(arr);
        //Console.WriteLine("Input: " + input);
        //Console.WriteLine("Output: " + output);

        //Task 6
        //string input = "aaabbccccd";

        //int maxBlock = 1;
        //int currentBlock = 1;

        //for (int i = 1; i < input.Length; i++)
        //{
        //    if (input[i] == input[i - 1])
        //    {
        //        currentBlock++;
        //    }
        //    else
        //    {
        //        if (currentBlock > maxBlock)
        //        {
        //            maxBlock = currentBlock;
        //        }
        //        currentBlock = 1;
        //    }
        //}
        //Console.WriteLine("Input: " + input);
        //Console.WriteLine("Output: " + maxBlock);

        //Task 7
        //string input = "abc";
        //string output = "";

        //foreach(char c in input)
        //{
        //    char shifted = (char)(c + 1);
        //    output += shifted;
        //}
        //Console.WriteLine("Input: " + input);
        //Console.WriteLine("Output: " + output);

        //Task 8
        //string input = "abca";
        //int left = 0;
        //int right = input.Length - 1;
        //bool canBePalindrome = true;

        //while (left < right)
        //{
        //    if (input[left] != input[right])
        //    {
        //        bool checkLeftRemoved= IsPalindrome(input, left + 1, right);
        //        bool checkRightRemoved = IsPalindrome(input, left, right - 1);
        //        canBePalindrome = checkLeftRemoved || checkRightRemoved;
        //        break;
        //    }
        //    left++;
        //    right--;
        //}
        //Console.WriteLine("Input: " + input);
        //Console.WriteLine("Output: " + (canBePalindrome ? "Can be palindrome" : "Cannot be palindrome"));

        //task 10
        string input = "LLRLLRR";
        int balance = 0;
        int totalParts = 0;

        foreach(char c in input)
        {
            if (c == 'L')
            {
                balance++;
            }
            else if (c == 'R')
            {
                balance--;
            }
            if (balance == 0)
            {
                totalParts++;
            }
        }
        Console.WriteLine("Input: " + input);   
        Console.WriteLine("Output: " + totalParts);
    }
    static bool IsPalindrome(string str,int left, int right)
    {
        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}