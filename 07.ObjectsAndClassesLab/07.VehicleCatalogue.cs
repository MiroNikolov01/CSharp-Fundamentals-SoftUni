namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carCatalog = new List<Car>();
            List<Truck> truckCatalog = new List<Truck>();

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "end") break;

                string[] properties = cmd.Split('/');
                string type = properties[0];
                string brand = properties[1];
                string model = properties[2];
                int powerOrWeight = int.Parse(properties[3]);

                if (type == "Car")
                {
                    carCatalog.Add(new Car { Brand = brand, Model = model, HorsePower = powerOrWeight });
                }
                else if (type == "Truck")
                {
                    truckCatalog.Add(new Truck { Brand = brand, Model = model, Weight = powerOrWeight });
                }
            }

            PrintCatalog("Cars", carCatalog.OrderBy(car => car.Brand).ToList(), "hp");
            PrintCatalog("Trucks", truckCatalog.OrderBy(truck => truck.Brand).ToList(), "kg");
        }

        static void PrintCatalog<T>(string title, List<T> vehicles, string unit) where T : IVehicle
        {
            if (vehicles.Count == 0) return;

            Console.WriteLine($"{title}:");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.GetSpec()}{unit}");
            }
        }
    }

    interface IVehicle
    {
        string Brand { get; }
        string Model { get; }
        int GetSpec();
    }

    class Car : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public int GetSpec() => HorsePower;
    }

    class Truck : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
        public int GetSpec() => Weight;
    }
}










