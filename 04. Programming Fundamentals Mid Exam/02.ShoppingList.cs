namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                   .Split('!')
                   .ToList();
            string cmd = string.Empty;
            while ((cmd = Console.ReadLine()) != "Go Shopping!")
            {
                string[] tokens = cmd.Split();
                string item = tokens[1];
                switch (tokens[0])
                {
                    case "Urgent":
                        if (!ValidItem(shoppingList, item))
                        {
                            shoppingList.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        if (ValidItem(shoppingList, item))
                        {
                            shoppingList.Remove(item);
                        }
                        break;
                    case "Correct":
                        string oldItem = tokens[1];
                        string newItem = tokens[2];
                        if (ValidItem(shoppingList, oldItem))
                        {
                            int indexItem = shoppingList.IndexOf(oldItem);
                            shoppingList[indexItem] = newItem;
                        }
                        break;
                    case "Rearrange":
                        if (ValidItem(shoppingList, item))
                        {
                            int indexItem = shoppingList.IndexOf(item);
                            string temp = shoppingList[indexItem];
                            shoppingList.Remove(temp);
                            shoppingList.Insert(shoppingList.Count, temp);
                        }
                        break;
                }

            }
            Console.WriteLine(string.Join(", ", shoppingList), StringSplitOptions.RemoveEmptyEntries);


        }
        static bool ValidItem(List<string> list, string item)
        {
            return list.Contains(item);
        }
    }
}







