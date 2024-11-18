namespace _02.ChangeList
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
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                switch (arguments[0])
                {
                    case "Delete":
                        int elementD = int.Parse(arguments[1]);
                        Delete(numbers, elementD);
                        break;
                    case "Insert":
                        int index = int.Parse(arguments[2]);
                        int position = int.Parse(arguments[1]);
                        Insert(numbers, index, position);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void Delete(List<int> list, int element)
        {
            list.RemoveAll(n => n == element);
        }
        static void Insert(List<int> list, int index, int position)
        {
            list.Insert(index, position);
        }
    }
}


