namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {

            int health = 100;
            int initialBitcoin = 0;
            int room = 0;
            string[] rooms = Console.ReadLine().Split(new char[] { '|' });
            for (int i = 0; i < rooms.Length; i++)
            {
                string roomStr = rooms[i];
                string[] tokens = roomStr.Split();
                room++;
                switch (tokens[0])
                {
                    case "potion":
                        int potion = int.Parse(tokens[1]);
                        int countHealthPoints = potion;
                        int testHealth = health;
                        testHealth += potion;
                        if (testHealth > 100)
                        {
                            countHealthPoints = 0;
                            for (int j = health; j < 100; j++)
                            {
                                health++;
                                countHealthPoints++;
                            }
                        }
                        else
                        {
                            health += potion;
                        }
                        Console.WriteLine($"You healed for {countHealthPoints} hp.\nCurrent health: {health} hp.");
                        break;
                    case "chest":
                        int bitcoin = int.Parse(tokens[1]);
                        initialBitcoin += bitcoin;
                        Console.WriteLine($"You found {bitcoin} bitcoins.");
                        break;
                    default:
                        int monster = int.Parse(tokens[1]);
                        health -= monster;
                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {tokens[0]}.\nBest room: {room}");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {tokens[0]}.");
                        }
                        break;

                }
            }
            Console.WriteLine($"You've made it!\nBitcoins: {initialBitcoin}\nHealth: {health}");
        }
    }
}










