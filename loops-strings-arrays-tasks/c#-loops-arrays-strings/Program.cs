using System;

class Program
{
    static void Main()
    {
        //Task 1
        //int[] ar = { 10, 15, 22, 7, 8, 13, 30 };
        //int evenCount = 0;
        //int oddCount = 0;
        //int sum = 0;

        //for (int i = 0; i < ar.Length; i++)
        //{
        //    if (ar[i] % 2 ==0)
        //    {
        //        evenCount++;
        //    }
        //    else
        //    {
        //        oddCount++;
        //    }

        //    sum += ar[i];
        //}

        //int avg = sum / ar.Length;
        //int avgCount = 0;
        //foreach (int num in ar)
        //{
        //    if (num > avg)
        //    {
        //        avgCount++;
        //    }
        //}


        //int[] aravg = new int[avgCount];
        //int index = 0;

        //foreach (int n in ar)
        //{
        //   if (n > avg)
        //    {
        //        aravg[index] = n;
        //        index++;
        //    }
        //}

        //Console.WriteLine("Even count: " + evenCount);
        //Console.WriteLine("Odd count: " + oddCount);
        //Console.WriteLine("Sum: " + sum);
        //Console.WriteLine("Average: " + avg);
        //Console.WriteLine("Filtered array " +"["+ string.Join(" , ", aravg)+"]");


        /////////////

        //Task 2

        //    int[] ar = { 12, 45, 7, 23, 56, 19 };

        //    int max = ar[0];

        //    for(int i =1; i<ar.Length; i++)
        //    {
        //        if (ar[i] > max)
        //        {
        //            max = ar[i];
        //        }
        //    }
        //    Console.WriteLine(max);



        ///////////////

        //Task 3

        //for (int i =1;i<=10; i++)
        //{
        //    if (i%2==0)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        ////////////

        //Task 4

        //Console.Write("Enter your Full Name: ");
        //string fullName = Console.ReadLine();
        //Console.Write("Enter your Age: ");  
        //int age = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter your Height: ");
        //double height = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Are you Employed (true/false):");
        //Boolean isEmpoyled = Convert.ToBoolean(Console.ReadLine());

        //Console.WriteLine("--- User Profile ---");
        //Console.WriteLine("Full Name: " + fullName);
        //Console.WriteLine("Age: " + age);
        //Console.WriteLine("Height: " + height);
        //Console.WriteLine("Employed:" + isEmpoyled);

        ////////////////

        //Task 5

        //Console.Write("Enter Your Name: ");
        //string name = Console.ReadLine();
        //Console.WriteLine("Your name in upper case "+name.ToUpper()+" Your name in Lower case " +name.ToLower());

        //Console.Write("Enter your age:");
        //int age = Convert.ToInt32(Console.ReadLine());
        //int ageInFive =age+ 5;
        //Console.WriteLine($"Your name is {name} and you're {age}"+ "and your age in 5 years will be: "+ ageInFive);

        //Console.WriteLine("The first character of your name is: " + name[0]);

        //Console.WriteLine("Name is\t:" + name);
        //Console.WriteLine("Age is\t:" + age);

        ///////////
        
        //Task 6

        for (int i =1; i<=10; i++)
        {
            if (i % 3 == 0)
                continue;
            if (i == 8)
                break;
            Console.WriteLine(i);
        }

    }
}
