using System;

namespace Task1
{
    class Person
    {
        public string Name { get; set; }

        private int age; 

        public void SetAge(int a)
        {
            if (a > 0) 
            {
                age = a; 
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age {age}");
        }

        class Student : Person
        {
            public void Study()
            {
                Console.WriteLine($"{Name} is studying hard.");
            }
        }

        sealed class FinalClass
        {
            public int Number { get; set; }
        }

        class Program
        {
            static void Main()
            {
                Student s1 = new Student();
                s1.Name = "Sarah";
                s1.SetAge(22);

                s1.PrintInfo();
                s1.Study();
            }
        }
    }
}