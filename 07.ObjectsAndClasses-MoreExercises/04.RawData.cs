namespace _04.RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int countCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < countCars; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string model = arguments[0];
                int engineSpeed = int.Parse(arguments[1]);
                int enginePower = int.Parse(arguments[2]);
                int cargoWeight = int.Parse(arguments[3]);
                string cargoType = arguments[4];
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    foreach (var car in cars.Where(c => c.Cargo.Weight < 1000))
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;
                case "flamable":
                    foreach (var car in cars.Where(c => c.Engine.Power > 250))
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;
            }
        }
        class Car
        {
            public string Model { get; set; }
            public Engine Engine { get; set; }
            public Cargo Cargo { get; set; }
            public Car(string model, Engine engine, Cargo cargo)
            {
                Model = model;
                Engine = engine;
                Cargo = cargo;
            }
        }
        class Engine
        {
            public int Speed { get; set; }
            public int Power { get; set; }
            public Engine(int speed, int power)
            {
                Speed = speed;
                Power = power;
            }
        }
        class Cargo
        {
            public int Weight { get; set; }
            public string Type { get; set; }
            public Cargo(int weight, string type)
            {
                Weight = weight;
                Type = type;
            }
        }
    }
}
