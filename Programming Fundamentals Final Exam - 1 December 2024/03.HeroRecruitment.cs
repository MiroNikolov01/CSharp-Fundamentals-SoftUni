using System.Xml.Linq;

namespace _03.HeroRecruitment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heroMaps = new Dictionary<string, Hero>();
            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] tokens = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Enroll":
                        Hero hero = new Hero(tokens[1]);
                        if (!heroMaps.ContainsKey(tokens[1]))
                        {
                            heroMaps.Add(tokens[1], hero);
                            break;
                        }
                        Console.WriteLine($"{tokens[1]} is already enrolled.");
                        break;
                    case "Learn":
                        if (heroMaps.ContainsKey(tokens[1]))
                        {
                            heroMaps[tokens[1]].Learn(tokens[1],
                                tokens[2],
                                heroMaps);
                            break;
                        }
                        Console.WriteLine($"{tokens[1]} doesn't exist.");
                        break;
                    case "Unlearn":
                        if (!heroMaps.ContainsKey(tokens[1]))
                        {
                            Console.WriteLine($"{tokens[1]} doesn't exist.");
                            break;
                        }
                        heroMaps[tokens[1]].Unlearn(tokens[1],
                            tokens[2],
                            heroMaps);
                        break;
                }
            }
            if (heroMaps.Count > 0)
            {
                Console.WriteLine("Heroes:");
                foreach (var hero in heroMaps.Values)
                {
                    Console.WriteLine(hero);
                }

            }
        }
    }
    class Hero
    {
        public string Name { get; set; }
        public List<string> SpellBook { get; set; } = new List<string>();
        public Hero(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            var spells = SpellBook.Count > 0 ? string.Join(", ", SpellBook) : "";
            return $"== {Name}: {spells}";
        }
        public void Learn(string name, string spell, Dictionary<string, Hero> heroMap)
        {
            if (heroMap[name].SpellBook.Contains(spell))
            {
                Console.WriteLine($"{name} has already learnt {spell}.");
                return;
            }
            heroMap[name].SpellBook.Add(spell);
        }
        public void Unlearn(string name, string spell, Dictionary<string, Hero> heroMap)
        {

            if (!heroMap[name].SpellBook.Contains(spell))
            {
                Console.WriteLine($"{name} doesn't know {spell}.");
                return;
            }
            heroMap[name].SpellBook.Remove(spell);

        }

    }
}
