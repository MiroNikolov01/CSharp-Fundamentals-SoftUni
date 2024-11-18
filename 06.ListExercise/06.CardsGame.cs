namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> playerTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> Winner;
            List<int> Loser;
            string WinnerName = "";

            do
            {
                if (playerOne[0] > playerTwo[0])
                {
                    Winner = playerOne;
                    Loser = playerTwo;
                    WinnerName = "First";
                }
                else
                {
                    Winner = playerTwo;
                    Loser = playerOne;
                    WinnerName = "Second";
                }
                if (Winner[0] != Loser[0])
                {
                    Winner.Add(Winner[0]);
                    Winner.Add(Loser[0]);
                }
                Winner.RemoveAt(0);
                Loser.RemoveAt(0);

            } while (Winner.Count > 0 && Loser.Count > 0);

            Console.WriteLine($"{WinnerName} player wins! Sum: {Winner.Sum()}");
            {
            }
        }
    }
}
