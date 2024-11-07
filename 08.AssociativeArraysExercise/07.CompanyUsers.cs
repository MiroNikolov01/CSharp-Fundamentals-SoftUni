namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pairs = new();
            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] arguments = cmd.Split(new string[] { "->", " " }, StringSplitOptions.RemoveEmptyEntries);
                if (!pairs.ContainsKey(arguments[0]))
                {
                    pairs[arguments[0]] = new List<string>();
                }
                if (!pairs[arguments[0]].Contains(arguments[1]))
                {
                    pairs[arguments[0]].Add(arguments[1]);
                }


            }
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.Key}\n-- {string.Join(" \n-- ", pair.Value)}");
            }
        }
    }
}
