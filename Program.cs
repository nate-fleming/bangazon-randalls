using System;
using System.Collections.Generic;

namespace randalls
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicle1 = new Dictionary<string, Dictionary<string, string>>();

            vehicle1.Add("vehicle", new Dictionary<string, string>() {
                {"year", "2008"},
                {"model", "Damfresh"},
                {"make", "Biotraxquote"},
                {"color", "sky magenta"}
            });

            vehicle1.Add("salesAgent", new Dictionary<string, string>(){
                {"mobile", "(896) 478-6975"},
                { "last_name", "Botsford"},
                {"first_name", "Shaina"}
            });

            var vehicle2 = new Dictionary<string, Dictionary<string, string>>();

            vehicle2.Add("vehicle", new Dictionary<string, string>() {
                {"year", "2010"},
                {"model", "Hotquadtrax"},
                {"make", "Transtintechno"},
                {"color", "robin egg blue"}
            });


            var vehicles = new List<Dictionary<string, Dictionary<string, string>>>();

            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            Car ford2 = new Car();
            ford2.Year = 2017;
            ford2.Model = "Fiesta";
            ford2.Make = "Ford";
            ford2.Price = 32500.65;

            var tesla2 = new Car()
            {
                Year = 2017,
                Model = "X",
                Make = "Tesla",
                Price = 80000.42
            };


            var garage = new List<Car>() { ford2, tesla2 };

            tesla2.Drive();

            tesla2.Drive(80);
        }
    }
}
