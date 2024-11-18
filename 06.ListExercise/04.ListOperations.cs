namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                switch (arguments[0])
                {
                    case "Add":
                        int addNumber = int.Parse(arguments[1]);
                        AddMethod(numbers, addNumber);
                        break;
                    case "Insert":
                        int index = int.Parse(arguments[2]);
                        int number = int.Parse(arguments[1]);
                        if (InvalidIndex(numbers, index))
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        InsertMethod(numbers, index, number);
                        break;
                    case "Remove":
                        int removeIndex = int.Parse(arguments[1]);
                        if (InvalidIndex(numbers, removeIndex))
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        RemoveMethod(numbers, removeIndex);
                        break;
                    case "Shift":
                        int countShift = int.Parse(arguments[2]);
                        string type = arguments[1];
                        ShiftMethod(numbers, type, countShift);
                        break;

                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void AddMethod(List<int> list, int addNumber)
        {
            list.Add(addNumber);
        }
        static void InsertMethod(List<int> list, int index, int insertNumber)
        {
            list.Insert(index, insertNumber);
        }
        static void RemoveMethod(List<int> list, int removeIndex)
        {
            list.RemoveAt(removeIndex);
        }
        static void ShiftMethod(List<int> list, string type, int count)
        {

            for (int j = 0; j < count; j++)
            {
                if (type == "left")
                {
                    list.Add(list[0]);
                    list.RemoveAt(0);
                }
                else if (type == "right")
                {
                    list.Insert(0, list[list.Count - 1]);
                    list.RemoveAt(list.Count - 1);
                }

            }


        }
        static bool InvalidIndex(List<int> list, int index)
        {
            return index < 0 || index > list.Count;

        }
    }
}


