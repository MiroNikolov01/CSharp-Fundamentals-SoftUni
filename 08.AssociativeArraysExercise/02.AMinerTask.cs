namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> arguments = new();
            string cmd = null;
            string resource = null;
            int quantity;
            while ((cmd = Console.ReadLine()) != "stop")
            {
               
                if (!arguments.ContainsKey(resource))
                {
                    arguments.Add(resource, 0);
                }
                    quantity = int.Parse(Console.ReadLine());
                arguments[resource] += quantity;

            }
            foreach (var argument in arguments)
            {
                Console.WriteLine($"{argument.Key} -> {argument.Value}");
            }
        }
    }
}
