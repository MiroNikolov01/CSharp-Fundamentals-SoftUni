using System.Security.Cryptography.X509Certificates;

namespace _03.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plantsMap = new();
            int countPlants = int.Parse(Console.ReadLine());
            for (int i = 0; i < countPlants; i++)
            {
                string information = Console.ReadLine();
                string[] plantTokens = information.Split("<->", StringSplitOptions.RemoveEmptyEntries);
                Plant plant = new Plant(plantTokens[0],
                    int.Parse(plantTokens[1]));
                if (!plantsMap.ContainsKey(plantTokens[0]))
                {
                    plantsMap.Add(plantTokens[0], plant);
                }
                plantsMap[plantTokens[0]].Update(int.Parse(plantTokens[1]));
            }
            string command;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] commandTokens = command.Split(new string[] { " - ", ": " }, StringSplitOptions.RemoveEmptyEntries);
                if (!plantsMap.ContainsKey(commandTokens[1]))
                {
                    Console.WriteLine("error");
                    continue;
                }
                switch (commandTokens[0])
                {
                    case "Rate":
                        plantsMap[commandTokens[1]].Rate
                            (commandTokens[1],
                            double.Parse(commandTokens[2]),
                            plantsMap);
                        break;
                    case "Update":
                        plantsMap[commandTokens[1]].Update
                            (int.Parse(commandTokens[2]));
                        break;
                    case "Reset":
                        plantsMap[commandTokens[1]].Reset
                            (commandTokens[1], plantsMap);
                        break;
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plantsMap.Values)
            {
                Console.WriteLine(plant);
            }
        }
    }
    class Plant
    {
        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<double> Rating { get; set; } = new List<double>();
        public Plant(string name, int rarity)
        {
            Name = name;
            Rarity = rarity;
        }
        public override string ToString()
        {
            var rating = Rating.Count > 0 ? Rating.Average() : 0.00;
            return $"- {Name}; Rarity: {Rarity}; Rating: {rating:F2}";
        }
        public void Update(int rarity)
        {
            Rarity = rarity;
        }
        public void Rate(string plantName, double rating, Dictionary<string, Plant> plantsMap)
        {
            plantsMap[plantName].Rating.Add(rating);
        }
        public void Reset(string plantName, Dictionary<string, Plant> plantsMap)
        {
            plantsMap[plantName].Rating.Clear();
        }
    }
}
