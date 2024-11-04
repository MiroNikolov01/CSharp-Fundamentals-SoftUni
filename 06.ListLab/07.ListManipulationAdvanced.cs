namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool listChanged = false;
            string strOut = string.Empty;//contains the required output
            List<int> list1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (String.IsNullOrEmpty(input)) continue;
                string operation;//contains operation string
                int numArg;//contains numbers
                int indArg;//contains indexes
                string strArg;//contains strings

                try
                {
                    (operation, numArg, indArg, strArg) = ParseInput(input);
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                switch (operation)
                {
                    case "Add":
                        list1.Add(numArg);
                        listChanged = true;
                        break;
                    case "Remove":
                        list1.Remove(numArg);
                        listChanged = true;
                        break;
                    case "RemoveAt":
                        list1.RemoveAt(indArg);
                        listChanged = true;
                        break;
                    case "Insert":
                        list1.Insert(indArg, numArg);
                        listChanged = true;
                        break;
                    case "Contains":
                        var contains = list1.Contains(numArg);
                        strOut = (contains) ? "Yes" : "No such number";
                        break;
                    case "PrintEven":
                        var evens = list1.Where(x => x % 2 == 0).ToList();
                        strOut = string.Join(" ", evens);
                        break;
                    case "PrintOdd":
                        var odds = list1.Where(x => x % 2 != 0).ToList();
                        strOut = string.Join(" ", odds);
                        break;
                    case "GetSum":
                        var sum = list1.Sum();
                        strOut = sum.ToString();
                        break;
                    case "Filter":
                        var filtered = Filter(list1, strArg, numArg);
                        strOut = string.Join(" ", filtered);
                        break;
                    default:
                        strOut = "Invalid command";
                        break;
                }
                Console.WriteLine(strOut);
            }
            if (listChanged) //or ListsDiffer
            {
                Console.WriteLine(string.Join(" ", list1));
            }

        }
        static List<int> Filter(List<int> list, string op, int number)
        {
            List<int> res = new List<int>();
            switch (op)
            {
                case ">":
                    foreach (var item in list)
                    {
                        if (item > number) res.Add(item);
                    }
                    return res;
                case "<":
                    foreach (var item in list)
                    {
                        if (item < number) res.Add(item);
                    }
                    return res;
                case ">=":
                    foreach (var item in list)
                    {
                        if (item >= number) res.Add(item);
                    }
                    return res;
                case "<=":
                    foreach (var item in list)
                    {
                        if (item <= number) res.Add(item);
                    }
                    return res;
            }
            return res;
        }

        static string[] GetArgs(string inputLine)
        {
            var inputArr = inputLine.Split(' ');
            return inputArr;
        }

        static int GetInt(string input)
        {
            var parsed = int.TryParse(input, out var val);
            if (!parsed)
                throw new Exception("Incorrect input");
            return val;
        }

        static bool ListsDiffer(List<int> list1, List<int> list2)
        {
            if (list1.Count != list2.Count) return true;
            for (var i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i])
                {
                    return true;
                }
            }
            return false;
        }

        static (string operation, int numArg, int indArg, string strArg) ParseInput(string input)
        {
            var inputParts = GetArgs(input);
            int numArg;//contains numbers
            int indArg;//contains indexes
            string strArg;//contains string argument (>=, =, etc)
            var operation = inputParts[0];//contains the operatin string
            switch (inputParts.Length)
            {
                case 2:
                    if (operation == "RemoveAt")
                    {
                        numArg = -1;
                        indArg = GetInt(inputParts[1]);
                    }
                    else
                    {
                        numArg = GetInt(inputParts[1]);
                        indArg = -1;
                    }
                    strArg = string.Empty;
                    break;
                case 3:
                    if (inputParts[0] == "Filter")
                    {
                        numArg = GetInt(inputParts[2]);
                        indArg = -1;
                        strArg = inputParts[1];
                    }
                    else //Insert
                    {
                        numArg = GetInt(inputParts[1]);
                        indArg = GetInt(inputParts[2]);
                        strArg = string.Empty;
                    }
                    break;
                default:
                    numArg = -1;
                    indArg = -1;
                    strArg = string.Empty;
                    break;
            }
            return (operation, numArg, indArg, strArg);
        }
    }
}

