using System;
using System.Runtime.InteropServices;

namespace StaticTasks
{
    static class MathUtilities
    {
        static int num;

        public static int squareOfNum(int num)
        {
            return num * num;
        }

        public static double squareOfSquare(int num)
        {
            return Math.Sqrt(num);
        }

        public static int maxBetweenTwo(int num1, int num2)
        {
            int max;
            if (num1 > num2)
            {
                max = num1;
            }
            else
            {
                max = num2;
            }
            return max;
        }
    }

    class Converter
    {
        static double celsiusToFehrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double kiloToMiles(double kilo)
        {
            return kilo * 0.621371;
        }

        class VisitorCounter
        {
            public static int totalVisitors = 0;

           public VisitorCounter()
            {
                totalVisitors++;
            }

        }

        class Company
        {
            public static string companyName { get; set; }

            public string EmployeeName { get; set; }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine($"Square of 5: {MathUtilities.squareOfNum(5)}");
                Console.WriteLine($"SquareRoot of 25: {MathUtilities.squareOfSquare(25)}");
                Console.WriteLine($"Max between 5 and 25: {MathUtilities.maxBetweenTwo(5, 25)}");

                Console.WriteLine($"100C is {Converter.celsiusToFehrenheit(100)} F");
                Console.WriteLine($"100 kilos is {Converter.kiloToMiles(100)} Mile");

                VisitorCounter v1 = new VisitorCounter();
                VisitorCounter v2 = new VisitorCounter();
                VisitorCounter v3= new VisitorCounter();
                VisitorCounter v4= new VisitorCounter();
                Console.WriteLine($"Total Visitors: {VisitorCounter.totalVisitors}");

                Company.companyName = "Shabbek";
                Company emp1 = new Company { EmployeeName = "Zina" };
                Company emp2 = new Company { EmployeeName = "Hala" };

                Console.WriteLine($"{emp1.EmployeeName} Works at {Company.companyName}");
                Console.WriteLine($"{emp2.EmployeeName} Works at {Company.companyName}");
            }
            
        }
    }

}
