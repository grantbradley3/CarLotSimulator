using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            var grantsCar = new Car();
            grantsCar.Make = "Toyota";
            grantsCar.Model = "Camry";
            grantsCar.Year = 2011;
            grantsCar.EngineNoise = "rubumbumbumbum";
            grantsCar.HonkNoise = "beep";
            grantsCar.IsDrivable = true;
            lot.Cars.Add(grantsCar);

            var stevesCar = new Car();
            stevesCar.Make = "Toyota";
            stevesCar.Model = "Hyundai";
            stevesCar.Year = 2018;
            stevesCar.EngineNoise = "vroom";
            stevesCar.HonkNoise = "beep";
            stevesCar.IsDrivable = true;
            lot.Cars.Add(stevesCar);

            var chadsCar = new Car();
            chadsCar.Make = "Ford";
            chadsCar.Model = "Mustang";
            chadsCar.Year = 1997;
            chadsCar.EngineNoise = "VROOM";
            chadsCar.HonkNoise = "honk";
            chadsCar.IsDrivable = true;
            lot.Cars.Add(chadsCar);

            var traceysCar = new Car()
            {
                Year = 2008,
                Make = "Volkswagon",
                Model = "Buggy",
                EngineNoise = "dopdopdop",
                HonkNoise = "bleep",
                IsDrivable = false
            };
            lot.Cars.Add(traceysCar);

            var brettsCar = new Car(2017, "Toyota", "Tacoma", "vrroooom", "doink", true);
            lot.Cars.Add(brettsCar);

            grantsCar.MakeEngineNoise();
            stevesCar.MakeEngineNoise();
            chadsCar.MakeEngineNoise();
            traceysCar.MakeEngineNoise();
            brettsCar.MakeEngineNoise();

            grantsCar.MakeHonkNoise();
            stevesCar.MakeHonkNoise();
            chadsCar.MakeHonkNoise();
            traceysCar.MakeHonkNoise();
            brettsCar.MakeHonkNoise();


            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model:{car.Model}");
            }
        }
    }
}
