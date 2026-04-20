using System;

namespace Task2
{
    class Car
    {
        public string Make;
        public int Year;
        public string Type;
        public double Price;
        public string Model;
        public string PalletNo;
        public string Color;

        public Car(string make, int year, string type, double price, string model, string palletNo, string color)
        {
            Make = make;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            PalletNo = palletNo;
            Color = color;
        }

        bool IsEngineOn = false;

        public void StartEngine()
        {
            IsEngineOn = true;
            Console.WriteLine($"The {Color} {Make} {Model}'s engine has started");
        }

        public void StopEnging()
        {
            IsEngineOn = false;
            Console.WriteLine($"The {Color} {Make} {Model}'s engine has stopped");
        }

        public string GetCarDetailes()
        {
            return $"~~~~~~~~ Car Details ~~~~~~~~~\n" + $"Make: {Make}\n" +
                   $"Model: {Model} ({Year})\n" + $"Type: {Type}\n" +
                   $"Color: {Color}\n" + $"Pallet No: {PalletNo}\n" +
                   $"Price: ${Price}\n" + $"Enging Running? {IsEngineOn}";
        }
    }

    class Program
    {
        static void Main()
        {
            Car myCar = new Car("Honda", 2024, "SUV", 32500.00, "CR-V", "10-98765" , "Matt Black");

            Console.WriteLine(myCar.GetCarDetailes());
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");

            myCar.StartEngine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");

            //To see the engine state changes
            Console.WriteLine(myCar.GetCarDetailes());


        }
    }
}