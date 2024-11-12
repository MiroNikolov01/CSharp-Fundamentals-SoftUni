namespace _03.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Car>> carCharacteristics = new();

            int numberOfCars = int.Parse(Console.ReadLine()); //Tracking
            for (int i = 0; i < numberOfCars; i++)
            {
               string information = Console.ReadLine();
                string[] characteristics = information.Split();

                string model = characteristics[0];
                double fuelAmount = double.Parse(characteristics[1]);
                double fuelConsumptionPerKm = double.Parse(characteristics[2]);
                Car car = new Car(fuelAmount,fuelConsumptionPerKm);
                if (!carCharacteristics.ContainsKey(model))
                {
                    carCharacteristics[model] = new List<Car>();
                }
                carCharacteristics[model].Add(car);
            }
            string driveCommand = string.Empty;
            while ((driveCommand = Console.ReadLine()) != "End")
            {
                string[] drivenInformation = driveCommand.Split();
                string model = drivenInformation[1];
                double amountDriven = double.Parse(drivenInformation[2]);

                if (carCharacteristics.ContainsKey(model))
                {
                    foreach (var car in carCharacteristics[model])
                    {
                        car.DistanceCalculation(amountDriven);
                    }
                }
               
            }
            foreach (var car in carCharacteristics)
            {
                foreach (var item in car.Value)
                {
                    Console.WriteLine($"{car.Key} {item.FuelAmount:F2} {item.TravelDistance}");
                }
            }

        }
        class Car
        {
            public double FuelAmount { get; set; }
            public double FuelConsumptionPerKm { get; set; }
            public double TravelDistance { get; set; } = 0;
            public Car(double fuelAmount, double fuelConsumption)
            {
                FuelAmount = fuelAmount;
                FuelConsumptionPerKm = fuelConsumption;
            }
           

           
            public void DistanceCalculation(double distance)
            {
                double requiredFuel = FuelConsumptionPerKm * distance;
                if (FuelAmount >= requiredFuel)
                {
                    FuelAmount -= requiredFuel;
                    TravelDistance += distance;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

            }
        }
    }
}