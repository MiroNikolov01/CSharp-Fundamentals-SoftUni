namespace _03.NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> carsMap = new();
            int carsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsCount; i++)
            {
                string carInformation = Console.ReadLine();
                string[] carTokens = carInformation.Split("|", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car
                    (carTokens[0],
                    int.Parse(carTokens[1]),
                    int.Parse(carTokens[2]));

                if (!carsMap.ContainsKey(carTokens[0]))
                {
                    carsMap.Add(carTokens[0], car);
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] carArguments = command.Split
                    (" : ", StringSplitOptions.RemoveEmptyEntries);
                switch (carArguments[0])
                {
                    case "Drive":
                        carsMap[carArguments[1]].Drive
                            (carArguments[1],
                            int.Parse(carArguments[2]),
                            int.Parse(carArguments[3]),
                            carsMap);
                        break;
                    case "Refuel":
                        carsMap[carArguments[1]].Refuel
                            (carArguments[1],
                            int.Parse(carArguments[2]),
                            carsMap);
                        break;
                    case "Revert":
                        carsMap[carArguments[1]].Revert
                            (carArguments[1],
                            int.Parse(carArguments[2]),
                            carsMap);
                        break;
                }
            }
            foreach (var car in carsMap.Values)
            {
                Console.WriteLine(car);
            }
        }
    }
    class Car
    {
        public string Name { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
        public Car(string name,int mileage, int fuel)
        {
            Name = name;
            Mileage = mileage;
            Fuel = fuel;
        }
        public override string ToString()
        {
            return $"{Name} -> Mileage: {Mileage} kms, Fuel in the tank: {Fuel} lt.";
        }
        public void Drive(string carName, int distance, int fuel, Dictionary<string, Car> carsMap)
        {
            const int reachedKilometers = 100_000;
            if (carsMap[carName].Fuel >= fuel)
            {
                carsMap[carName].Fuel -= fuel;
                carsMap[carName].Mileage += distance;
                Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                if (carsMap[carName].Mileage >= reachedKilometers)
                {
                    carsMap.Remove(carName);
                    Console.WriteLine($"Time to sell the {carName}!");
                }
                return;
            }
            Console.WriteLine("Not enough fuel to make that ride");
        }
        public void Refuel(string carName, int fuel, Dictionary<string, Car> carsMap)
        {
            const int tankMax = 75;
            if (carsMap[carName].Fuel + fuel > tankMax)
            {
                fuel = tankMax - carsMap[carName].Fuel;
                carsMap[carName].Fuel = tankMax;
               PrintRefuel(carName, fuel);
                return;
            }
            carsMap[carName].Fuel += fuel;
           PrintRefuel(carName, fuel);
        }
        public void Revert(string carName, int kilometers, Dictionary<string, Car> carsMap)
        {
            const int minMileage = 10_000;
            carsMap[carName].Mileage -= kilometers;
            
            if (carsMap[carName].Mileage < minMileage)
            {
                carsMap[carName].Mileage = minMileage;
                return;
            }
            Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
        }
        public void PrintRefuel(string name, int fuel)
        {
            Console.WriteLine($"{name} refueled with {fuel} liters");
       }
    }
}
