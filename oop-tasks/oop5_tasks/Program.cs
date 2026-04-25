using System;

namespace InterfaceException_Task
{
    interface ICalculator
    {
        int Add(int a, int b);
    }

   class Calculator : ICalculator
    {
       public int Add (int a , int b)
        {
            return a + b;
        }
    }
    
    class Program
    {
        static void Main()
        {
            Calculator mycalc = new Calculator();

            try
            {
                Console.WriteLine("Enter a number");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = mycalc.Add(num1, num2);
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: You must enter valid Whole number");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: "+ ex.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Calculator opereationn finished.");   
            }
        }
    }
}
