namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string cmd = string.Empty;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] arguments = cmd.Split();
                int index = int.Parse(arguments[1]);
                if (arguments[0] == "Shoot")
                {
                    int power = int.Parse(arguments[2]);
                    if (IfExists(numbersList, index))
                    {
                        if (power >= numbersList[index])
                        {
                            numbersList.Remove(numbersList[index]);
                        }
                        else if (numbersList[index] <= 0)
                        {
                            numbersList.Remove(numbersList[index]);
                        }
                        else
                        {
                            numbersList[index] -= power;
                        }
                    }

                }
                else if (arguments[0] == "Add")
                {
                    int value = int.Parse(arguments[2]);
                    if (IfExists(numbersList, index))
                    {
                        numbersList.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (arguments[0] == "Strike")
                {
                    int indexStrike = int.Parse(arguments[1]);
                    int radius = int.Parse(arguments[2]);
                    if (IfExists(numbersList, index))
                    {

                        int rightIndex = indexStrike + radius;
                        int leftIndex = indexStrike - radius;

                        if (leftIndex >= 0 && rightIndex < numbersList.Count)
                        {
                            int range = rightIndex - leftIndex + 1;

                            numbersList.RemoveRange(leftIndex, range);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                    }
                }

            }
            Console.WriteLine(string.Join("|", numbersList));
        }
        static bool IfExists(List<int> list, int index)
        {
            return index >= 0 && index <= list.Count - 1;
        }
    }
}

