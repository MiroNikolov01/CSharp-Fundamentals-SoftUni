using System.Security.Cryptography.X509Certificates;

namespace _03.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heroesMap = new Dictionary<string, Hero>();
            int countHeroes = int.Parse(Console.ReadLine());
            for (int i = 0; i < countHeroes; i++)
            {
                string heroInput = Console.ReadLine();
                string[] heroTokens = heroInput.Split
                    (' ', StringSplitOptions.RemoveEmptyEntries);
                string name = heroTokens[0];
                int hp = int.Parse(heroTokens[1]);
                int mp = int.Parse(heroTokens[2]);
                Hero hero = new Hero(name, hp, mp);
                if (!heroesMap.ContainsKey(name))
                {
                    heroesMap.Add(name, hero);
                }
            }
            string actions;
            while ((actions = Console.ReadLine()) != "End")
            {
                string[] arguments = actions.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                switch (arguments[0])
                {
                    case "CastSpell":
                        heroesMap[arguments[1]].CastSpell
                            (arguments[1],
                            int.Parse(arguments[2]),
                            arguments[3],
                            heroesMap);
                        break;
                    case "TakeDamage":
                        heroesMap[arguments[1]].TakeDamage
                            (arguments[1],
                            int.Parse(arguments[2]),
                            arguments[3],
                            heroesMap);
                        break;
                    case "Recharge":
                        heroesMap[arguments[1]].Recharge
                            (arguments[1],
                            int.Parse(arguments[2]),
                            heroesMap);
                        break;
                    case "Heal":
                        heroesMap[arguments[1]].Heal
                            (arguments[1],
                            int.Parse(arguments[2]),
                            heroesMap);
                        break;


                }
            }
            if (heroesMap.Count > 0)
            {
                foreach (var hero in heroesMap.Values)
                {
                    Console.WriteLine(hero);
                }
            }
        }
    }
    class Hero
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public Hero(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;
        }
        public override string ToString()
        {
            return $"{Name}\n HP: {HP}\n MP: {MP}";
        }
        public void CastSpell(string heroName, int mp, string spellName, Dictionary<string, Hero> mapHeroes)
        {
            if (mapHeroes[heroName].MP >= mp)
            {
                mapHeroes[heroName].MP -= mp;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {mapHeroes[heroName].MP} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
        }
        public void TakeDamage(string heroName, int damage, string attacker, Dictionary<string, Hero> mapHeroes)
        {
            if (mapHeroes[heroName].HP > damage)
            {
                mapHeroes[heroName].HP -= damage;

                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {mapHeroes[heroName].HP} HP left!");
            }
            else
            {
                mapHeroes.Remove(heroName);
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
            }
        }
        public void Recharge(string heroName, int amount, Dictionary<string, Hero> mapHeroes)
        {
            const int maxManaPoints = 200;
            int amountRecovered = 0;
            if (maxManaPoints < amount + mapHeroes[heroName].MP)
            {
                amountRecovered = maxManaPoints - mapHeroes[heroName].MP;
                mapHeroes[heroName].MP = maxManaPoints;
            }
            else
            {
                mapHeroes[heroName].MP += amount;
                amountRecovered = amount;
            }
            Console.WriteLine($"{heroName} recharged for {amountRecovered} MP!");
        }
        public void Heal(string heroName, int amount, Dictionary<string, Hero> mapHeroes)
        {
            const int maxHealPoints = 100;
            int amountRecovered = 0;
            if (maxHealPoints < amount + mapHeroes[heroName].HP)
            {
                amountRecovered = maxHealPoints - mapHeroes[heroName].HP;
                mapHeroes[heroName].HP = maxHealPoints;
            }
            else
            {
                mapHeroes[heroName].HP += amount;
                amountRecovered = amount;
            }
            Console.WriteLine($"{heroName} healed for {amountRecovered} HP!");
        }
    }
}
