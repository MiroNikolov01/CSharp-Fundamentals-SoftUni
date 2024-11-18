namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();
            List<string> noEntryList = new List<string>();
            for (int i = 1; i <= count; i++)
            {
                string command = Console.ReadLine();
                string[] argument = command.Split();
                if (argument[1] == "is" && argument[2] == "going!")
                {
                    if (guestList.Contains(argument[0]))
                    {

                        Console.WriteLine($"{argument[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(argument[0]);
                    }
                }
                else if (argument[2] == "not")
                {
                    if (guestList.Contains(argument[0]))
                    {
                        guestList.Remove(argument[0]);
                        continue;
                    }
                    Console.WriteLine($"{argument[0]} is not in the list!");
                }
            }
            foreach (var peopleGoing in guestList)
            {
                Console.WriteLine(peopleGoing);
            }

        }
    }
}


