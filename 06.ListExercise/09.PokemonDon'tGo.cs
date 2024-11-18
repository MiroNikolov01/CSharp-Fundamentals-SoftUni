namespace _09.PokemonDon_tGo
{
    class Program
    {
        static void Main()
        {
            List<int> pokemons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> removedPokemons = new List<int>();
            while (pokemons.Count != 0)
            {
                int removedValue;

                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    removedValue = pokemons[0];
                    pokemons[0] = pokemons[^1];
                }
                else if (index > pokemons.Count - 1)
                {
                    removedValue = pokemons[^1];
                    pokemons[^1] = pokemons[0];
                }
                else
                {
                    removedValue = pokemons[index];
                    pokemons.RemoveAt(index);
                }

                removedPokemons.Add(removedValue);

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (removedValue >= pokemons[i])
                    {
                        pokemons[i] += removedValue;
                    }
                    else
                    {
                        pokemons[i] -= removedValue;
                    }
                }
            }
            int summedValue = removedPokemons.Sum();
            Console.WriteLine(summedValue);
        }
    }
}