namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToList();
            string cmd = null;
            while ((cmd = Console.ReadLine()) != "Craft!")
            {
                string[] items = cmd.Split(new string[] { " - ", ":" }, StringSplitOptions.None);
                switch (items[0])
                {
                    case "Collect":
                        string itemAdd = items[1];
                        if (!Exist(inventory, itemAdd))
                        {
                            inventory.Add(itemAdd);
                        }
                        break;
                    case "Drop":
                        string itemDrop = items[1];

                        if (Exist(inventory, itemDrop))
                        {
                            inventory.Remove(itemDrop);
                        }
                        break;
                    case "Combine Items":

                        string oldItem = items[1];
                        string newItem = items[2];
                        if (Exist(inventory, oldItem))
                        {
                            int index = inventory.IndexOf(oldItem);
                            inventory.Insert(index + 1, newItem);
                        }
                        break;
                    case "Renew":
                        string item = items[1];

                        if (Exist(inventory, item))
                        {
                            string temp = item;
                            inventory.Remove(item);
                            inventory.Add(temp);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", inventory));

        }
        static bool Exist(List<string> list, string item)
        {
            return list.Contains(item);
        }
    }
}










