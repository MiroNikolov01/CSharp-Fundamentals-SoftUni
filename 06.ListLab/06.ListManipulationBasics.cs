namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(' ');
                switch (arguments[0])
                {
                    case "Add":
                        int numberAdd = int.Parse(arguments[1]);
                        AddMethod(numbers, numberAdd);
                        break;
                    case "Remove":
                        int numberRemove = int.Parse(arguments[1]);
                        RemoveMethod(numbers, numberRemove);
                        break;
                    case "RemoveAt":
                        int indexAt = int.Parse(arguments[1]);
                        if (!ValidIndex(numbers, indexAt))
                        {
                            break;
                        }
                        RemoveAtMethod(numbers, indexAt);
                        break;
                    case "Insert":
                        int numberInsert = int.Parse(arguments[1]);
                        int indexInsert = int.Parse(arguments[2]);
                        if (!ValidIndex(numbers, indexInsert))
                        {
                            break;
                        }
                        InsertMethod(numbers, indexInsert, numberInsert);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void AddMethod(List<int> list, int number)
        {
            list.Add(number);
        }
        static void RemoveMethod(List<int> list, int number)
        {
            list.Remove(number);
        }
        static void RemoveAtMethod(List<int> list, int index)
        {
            list.RemoveAt(index);
        }
        static void InsertMethod(List<int> list, int index, int number)
        {
            list.Insert(index, number);
        }
        static bool ValidIndex(List<int> list, int number)
        {
            return number >= 0 && number < list.Count - 1;
        }
    }
}
