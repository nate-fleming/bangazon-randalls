using System;

namespace randalls
{
    class Car
    {
        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public double Price { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Make}: I'm drivin here!!!");
        }

        public void Drive(int miles)
        {
            Console.WriteLine($"{Make} is driving for {miles} miles");
        }
    }
}