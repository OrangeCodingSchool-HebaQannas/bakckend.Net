using System;

namespace OOPTasks
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("An Animal makes a sound");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("A dog says: Woof");
            }
        }
        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("A cat says: Meow");
            }
        }

        class Person
        {
            private int age;

            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    if (value >= 0)
                    {
                        age = value;
                    }
                    else
                    {
                        Console.WriteLine("Age cannot be negative");
                    }
                }
            }
        }

        abstract class Shape
        {
            public abstract double getArea();
        }

        class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double getArea()
            {
                return Width * Height;
            }
        }

        abstract class Appliance
        {
            public abstract void TurnOn();
            public abstract void TurnOff();

            public string Brand { get; set; }
        }

        class WashingMachine : Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine($"{Brand} Washing Machine is Starting");
            }
            public override void TurnOff()
            {
                Console.WriteLine($"{Brand} Washing Machine is Turning Off");
            }
        }

        class AirConditionar : Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine($"{Brand} AC is Starting. Cooling Mode Active");
            }
            public override void TurnOff()
            {
                Console.WriteLine($"{Brand} AC fan slowing down. Powering Off");
            }
        }

        class BankAccount
        {
            private double balance;

            public double Balance
            {
                get { return balance; }
            }

            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposited {amount}. New balance = {balance}");
                }
            }

            public void Withdraw(double amount)
            {
                if (amount > balance)
                {
                    Console.WriteLine($"Error: Insufficient Funds. You only have {balance}");
                }
                else if (amount > 0)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew {amount}. New balance {balance}");
                }
            }
        }

        abstract class Employee
        {
            public string Name { get; set; }

            public abstract double CalculateSalary();
        }

        class fullTimeEmployee : Employee
        {
            public double MonthlySalary {  get; set; }
            public override double CalculateSalary()
            {
                return MonthlySalary;
            }
        }

        class partTimeEmployee : Employee
        {
            public double hourlyRate { get; set; }
            public int hoursWorked { get; set; }
            public override double CalculateSalary()
            {
                return hourlyRate * hoursWorked;
            }
        }


        class Program
        {
            static void Main()
            {
                Calculator calc = new Calculator();
                Console.WriteLine($"2 + 3 = {calc.Add(2,3)}");
                Console.WriteLine($"2 + 3 + 4 = {calc.Add(2, 3, 4)}");
                Console.WriteLine($"2.5 + 3.5 = {calc.Add(2.5, 3.5)}");

                Animal myDog = new Dog();
                Animal myCat = new Cat();
                myDog.MakeSound();
                myCat.MakeSound();

                //Appliance
                Appliance washer = new WashingMachine { Brand = "LG" };
                Appliance ac = new AirConditionar { Brand = "Hyundai" };
                washer.TurnOn();
                ac.TurnOff();

                //Encapsulation
                BankAccount account = new BankAccount();
                account.Deposit(500);
                account.Withdraw(599);
                account.Withdraw(200);

                //employee
                Employee fulltime = new fullTimeEmployee { Name = "Issa", MonthlySalary = 786.5 };
                Employee parttime = new partTimeEmployee { Name = "Eman", hourlyRate = 20, hoursWorked = 85 };
                Console.WriteLine($"{fulltime.Name}'s Salary: {fulltime.CalculateSalary()}");
                Console.WriteLine($"{ parttime.Name}'s Salary: {parttime.CalculateSalary()}");
            }
        }
    }
}