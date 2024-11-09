namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehiclesCatalog = new List<Vehicle>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();
                string type = arguments[0];
                string model = arguments[1];
                string color = arguments[2];
                double horsePower = double.Parse(arguments[3]);
                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehiclesCatalog.Add(vehicle);
            }
            string typeCar;
            while ((typeCar = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehiclesCatalog)
                {
                    if (typeCar == vehicle.Model)
                    {
                        Console.WriteLine(vehicle.ToString());
                        break;
                    }
                }
            }
            PrintAverageSum(vehiclesCatalog, "Car");
            PrintAverageSum(vehiclesCatalog, "Truck");

        }
        static void PrintAverageSum(List<Vehicle> list, string type)
        {
            double sum = 0; double counter = 0;
            foreach (Vehicle vehicle in list)
            {
                if (vehicle.Type == type)
                {
                    sum += vehicle.HorsePower;
                    counter++;
                }
            }
            double average = counter > 0 ? sum / counter : 0;

            Console.WriteLine($"{type}s have average horsepower of: {average:F2}.");
        }
    }
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
        public Vehicle(string type, string model, string color, double horsePower)
        {

            Type = type == "car" ? "Car" : "Truck";
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public override string ToString()
        {


            return ($"Type: {Type}\n" +
               $"Model: {Model}\n" +
               $"Color: {Color}\n" +
               $"Horsepower: {HorsePower}");


        }
    }
}




