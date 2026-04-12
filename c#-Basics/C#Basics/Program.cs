using System;
using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        //Task 1
        string name = "Heba";
        int age = 21;
        Console.WriteLine("My name is " + name + "and I am  " + age + " Years Old");

        //task 2
        Console.WriteLine("Please Enter a number to test if Even or Odd");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The Number " + number + " is even");
        }
        else
        {
            Console.WriteLine("The number " + number + " is odd");
        }

        //Task 3
        Console.WriteLine("Please Enter a string");
        string str = Console.ReadLine();
        Console.WriteLine(str);

        //Task 4
        int n = 10;
        if (n > 0)
        {
            Console.WriteLine("The number " + n + "is positive");
        }
        else if (n < 0)
        {
            Console.WriteLine("The number is" + n + " negative");
        }
        else
        {
            Console.WriteLine("The number" + n + "is 0");
        }

        //Task 5
        Console.WriteLine("Enter Any Year to check if it is a leap year or not");
        int year = Convert.ToInt32(Console.ReadLine());
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("The year " + year + " is a leap year");
        }
        else
        {
            Console.WriteLine("The year " + year + " is not a leap year");
        }

        //task 6
        Console.WriteLine("Enter Your Grade");
        int grade = Convert.ToInt32(Console.ReadLine());
        if (grade < 50 && grade > 0)
        {
            Console.WriteLine("Fail");
        }
        else if (n >= 50 && grade < 100)
        {
            Console.WriteLine("Pass");
        }

        //Task 7
        int num1 = 10;
        int num2 = 20;
        if (num1 > num2)
        {
            Console.WriteLine("The larger number is " + num1);
        }
        else if (num2 > num1)
        {
            Console.WriteLine("The larger number is " + num2);
        }
        else
        {
            Console.WriteLine("Both numbers are equal");
        }

        //Task 8
        int num3 = 15;
        if (num3 % 3 == 0 && num3 % 5 == 0)
        {
            Console.WriteLine("The number " + num3 + " is divisible by 3 and 5");
        }

        //Task 9
        Console.WriteLine("Enter a character to check if it is a vowel or consonant");
        char c = Convert.ToChar(Console.ReadLine());
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
            c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        {
            Console.WriteLine("The character " + c + " is a vowel");
        }
        else
        {
            Console.WriteLine("The character " + c + " is a consonant");
        }

        //Task 10
        Console.WriteLine("Enter Your Age");
        int personAge = Convert.ToInt32(Console.ReadLine());
        if (personAge < 12)
        {
            Console.WriteLine("You are a child");
        }
        else if (personAge >= 12 && personAge < 18)
        {
            Console.WriteLine("You are a teenager");
        }
        else
        {
            Console.WriteLine("You are an adult");
        }

        //Task 11
        Console.WriteLine("Enter a number to check the Day of the week");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid day number");
                break;
        }

        //Task 12
        Console.WriteLine("Enter a number to check the Month of the year");
        int monthNumber = Convert.ToInt32(Console.ReadLine());

        switch (monthNumber)
        {
            case 1:
                Console.WriteLine("January");
                break;
            case 2:
                Console.WriteLine("February");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("June");
                break;
            case 7:
                Console.WriteLine("July");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("September");
                break;
            case 10:
                Console.WriteLine("October");
                break;
            case 11:
                Console.WriteLine("November");
                break;
            case 12:
                Console.WriteLine("December");
                break;
            default:
                Console.WriteLine("Invalid month number");
                break;
        }

        //Task 13
        char op = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter the first number");
        int numA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        int numB = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine("The sum is: " + (numA + numB));
                break;
            case '-':
                Console.WriteLine("The difference is: " + (numA - numB));
                break;
            case '*':
                Console.WriteLine("The product is: " + (numA * numB));
                break;
            case '/':
                if (numB != 0)
                {
                    Console.WriteLine("The quotient is: " + (numA / numB));
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }

        //Task 14
        Console.WriteLine("Enter a grade to check the letter grade");
        int grade2 = Convert.ToInt32(Console.ReadLine());

        switch (grade2)
        {
            case (>= 90):
                Console.WriteLine("A");
                break;
            case (>= 80):
                Console.WriteLine("B");
                break;
            case (>= 70):
                Console.WriteLine("C");
                break;
            case (>= 60):
                Console.WriteLine("D");
                break;
            case (>= 0):
                Console.WriteLine("F");
                break;
            default:
                Console.WriteLine("Invalid grade");
                break;
        }

        //Task 15
        Console.WriteLine("Enter a number to read a meaningful message");
        int num4 = Convert.ToInt32(Console.ReadLine());
        switch (num4)
        {
            case 1:
                Console.WriteLine("Believe you can and you're halfway there.");
                break;
            case 2:
                Console.WriteLine("Be the change you wish to see in the world.");
                break;
            case 3:
                Console.WriteLine("It does not matter how slowly you go as long as you do not stop.");
                break;
            default:
                Console.WriteLine("Number out of range");
                break;
        }

        //Task 16
        Console.WriteLine("Enter a number to know if it is odd or even");
        int num5 = Convert.ToInt32(Console.ReadLine());

        switch (num5 % 2)
        {
            case 0:
                Console.WriteLine("The number " + num5 + " is even");
                break;
            case 1:
                Console.WriteLine("The number " + num5 + " is odd");
                break;
            default:
                Console.WriteLine("Invalid number");
                break;
        }

        //Task 17
        Console.WriteLine("Enter Your role (Admin, User, Guest)");
        string role = Console.ReadLine();
        switch (role)
        {
            case "Admin":
                Console.WriteLine("Welcome, Admin! You have full access.");
                break;
            case "User":
                Console.WriteLine("Welcome, User! You have limited access.");
                break;
            case "Guest":
                Console.WriteLine("Welcome, Guest! You have read-only access.");
                break;
            default:
                Console.WriteLine("Invalid role");
                break;
        }

        //Task 18
        Console.WriteLine("Press 1 to calculate area of a circle");
        Console.WriteLine("Press 2 to calculate area of a square");
        Console.WriteLine("Press 3 to calculate area of a sphere");
        Console.WriteLine("Enter your choice");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter the radius of the circle");
                double radius = Convert.ToDouble(Console.ReadLine());
                double areaCircle = Math.PI * radius * radius;
                Console.WriteLine("The area of the circle is: " + areaCircle);
                break;
            case 2:
                Console.WriteLine("Enter the side length of the square");
                double side = Convert.ToDouble(Console.ReadLine());
                double areaSquare = side * side;
                Console.WriteLine("The area of the square is: " + areaSquare);
                break;
            case 3:
                Console.WriteLine("Enter the radius of the sphere");
                double radiusSphere = Convert.ToDouble(Console.ReadLine());
                double areaSphere = 4 * Math.PI * radiusSphere * radiusSphere;
                Console.WriteLine("The surface area of the sphere is: " + areaSphere);
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        //////// Advanced if statements questions

        //Task 1
        Console.WriteLine("Enter your rating");
        int rating = Convert.ToInt32(Console.ReadLine());

        if (rating >= 90 && rating <= 100)
        {
            Console.WriteLine("Excellent + 20% bonus");
        }
        else if (rating >= 75 && rating < 90)
        {
            Console.WriteLine("Very Good + 15% bonus");
        }
        else if (rating >= 60 && rating < 75)
        {
            Console.WriteLine("Good + 10% bonus");
        }
        else if (rating < 60)
        {
            Console.WriteLine("No bonus");
        }
        else
        {
            Console.WriteLine("Invalid rating. Please enter a number between 1 and 5.");
        }

        //Task 2
        Console.WriteLine("Enter Your GPA");
        double gpa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Did you pass your English course? (yes/no)");
        string passedEnglish = Console.ReadLine().ToLower();
        Console.WriteLine("Do you have a special Recommendation? (yes/no)");
        string hasRecommendation = Console.ReadLine().ToLower();

        if ((gpa >= 85 && passedEnglish == "yes") || hasRecommendation == "yes")
        {
            Console.WriteLine("You are eligible for the University admission");
        }
        else
        {
            Console.WriteLine("You are not eligible for the University addmission");
        }

        //Task 3

        Console.WriteLine("Enter the weight of the package in kg");
        double weight = Convert.ToDouble(Console.ReadLine());

        if (weight <= 1)
        {
            Console.WriteLine("The shipping cost is $5");
        }
        else if (weight > 1 && weight <= 5)
        {
            Console.WriteLine("The shipping cost is $10");
        }
        else if (weight > 5 && weight <= 10)
        {
            Console.WriteLine("The shipping cost is $20");
        }
        else
        {
            Console.WriteLine("Warning: The package is HEAVY!! and ");
            Console.WriteLine("The shipping cost is $50");
        }

        //Task 4
        string correctUsername = "admin";
        string correctPassword = "password123";
        int maxAttempts = 3;
        int attempts = 0;

        while (attempts < maxAttempts)
        {
            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login successful!");
                break;
            }
            else
            {
                attempts++;
                Console.WriteLine("Invalid username or password. Please try again.");
                if (attempts == maxAttempts)
                {
                    Console.WriteLine("Maximum login attempts reached. Access denied.");
                }
            }

            // Switch Advances questions

            //Task 1

            Console.WriteLine("Enter your choice to see your item from menu");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("You have selected Burger and the price is 5$");
                    break;
                case 2:
                    Console.WriteLine("You have selected Pizza and the price is 8$");
                    break;
                case 3:
                    Console.WriteLine("You have selected Pasta and the price is 7$");
                    break;
                case 4:
                    Console.WriteLine("You have selected Salad and the price is 4$");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid menu item.");
                    break;
            }

            Console.WriteLine("1 for Checking Balance");
            Console.WriteLine("2 for Deposit");
            Console.WriteLine("3 for Withdraw");
            Console.WriteLine("Exit");
            Console.WriteLine("Enter your choice");
            int atmChoice = Convert.ToInt32(Console.ReadLine());

            double balance = 1000; // Initial balance

            switch (atmChoice)
            {
                case 1:
                    Console.WriteLine("Your current balance is: $" + balance);
                    break;
                case 2:
                    Console.WriteLine("Enter the amount to deposit:");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    balance += depositAmount;
                    Console.WriteLine("Deposit successful! Your new balance is: $" + balance);
                    break;
                case 3:
                    Console.WriteLine("Enter the amount to withdraw:");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    if (withdrawAmount <= balance)
                    {
                        balance -= withdrawAmount;
                        Console.WriteLine("Withdrawal successful! Your new balance is: $" + balance);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds. Withdrawal failed.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Thank you for using our ATM. Goodbye!");
                    break;
            }
        }
    }
}
