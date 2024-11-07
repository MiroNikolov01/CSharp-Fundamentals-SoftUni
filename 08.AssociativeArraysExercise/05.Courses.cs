namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, (List<string>, int Count) >pairs = new();
            string cmd;
            while ((cmd = Console.ReadLine()) != "end")
            {
                string[] arguments = cmd.Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                if (!pairs.ContainsKey(arguments[0]))
                {
                    pairs[arguments[0]] = (new List<string>(),0);
                }
                if (!pairs[arguments[0]].Item1.Contains(arguments[1]))
                {
                    var currentTuple = pairs[arguments[0]];
                    pairs[arguments[0]].Item1
                        .Add(arguments[1]);

                    currentTuple.Count += 1;

                    
                    pairs[arguments[0]] = currentTuple;
                }


            }
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count}\n-- {string.Join(" \n-- ", pair.Value.Item1)}");
            }
        }
    }
}
