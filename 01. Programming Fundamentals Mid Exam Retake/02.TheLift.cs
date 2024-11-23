namespace _02.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            const int wagonCapacity = 4;
            for (int i = 0; i < wagons.Length; i++)
            {
                int spaceLeft = wagonCapacity - wagons[i];
                int peopleToEnter = Math.Min(spaceLeft, peopleWaiting);
                wagons[i] += peopleToEnter;
                peopleWaiting -= peopleToEnter;
                if (peopleWaiting == 0)
                {
                    break;
                }
            }
            if (peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (wagons.Any(w => w < wagonCapacity))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else
            {
                Console.WriteLine(string.Join(" ", wagons));
            }

        }

    }
}
