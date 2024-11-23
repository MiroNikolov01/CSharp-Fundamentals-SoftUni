namespace _01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)

        {
            int energy = int.Parse(Console.ReadLine());
            string distanceStr = string.Empty;
            int countWins = 0;
            while ((distanceStr = Console.ReadLine()) != "End of battle")
            {
                int distane = int.Parse(distanceStr);
                if (energy < distane)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countWins} won battles and {energy} energy");
                    return;
                }
                else if (energy >= distane)
                {
                    countWins++;
                    energy -= distane;
                }
                if (countWins % 3 == 0)
                {
                    energy += countWins;
                }
            }
            Console.WriteLine($"Won battles: {countWins}. Energy left: {energy}");
        }
    }
}







