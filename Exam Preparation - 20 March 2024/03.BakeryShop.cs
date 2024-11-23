using System.Collections.Specialized;

namespace _03.BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Food> productsMap = new Dictionary<string, Food>();
            string command;
            int totalSoldFood = 0;
            while ((command = Console.ReadLine()) != "Complete")
            {
                string[] tokens = command.Split();
                int quantity = int.Parse(tokens[1]);
                string food = tokens[2];
                Food productInfo = new Food(quantity);
                switch (tokens[0])
                {
                    case "Receive":
                        Recieve(quantity, food, productsMap);
                        break;
                    case "Sell":
                        totalSoldFood += Sell(quantity, food, productsMap);
                        break;
                }
            }
            foreach (var product in productsMap)
            {
                Console.WriteLine($"{product.Key}: {product.Value.Quantity}");
            }
            Console.WriteLine($"All sold: {totalSoldFood} goods");
        }
        private static int Sell(int quantity, string productName, Dictionary<string, Food> productsMap)
        {
            int totalSoldFood = 0;

            if (!productsMap.ContainsKey(productName))
            {
                Console.WriteLine($"You do not have any {productName}.");
                return 0;
            }
            if (productsMap[productName].Quantity < quantity)
            {
                int quantityLeft = productsMap[productName].Quantity;
                productsMap[productName].Quantity -= productsMap[productName].Quantity;
                totalSoldFood += quantityLeft;
                productsMap.Remove(productName);
                Console.WriteLine($"There aren't enough {productName}. You sold the last {quantityLeft} of them.");
            }
            else
            {
                productsMap[productName].Quantity -= quantity;
                Console.WriteLine($"You sold {quantity} {productName}.");
                totalSoldFood += quantity;
                if (productsMap[productName].Quantity <= 0)
                {
                    productsMap.Remove(productName);
                }
            }

            return totalSoldFood;
        }

        public static void Recieve(int quantity, string productName, Dictionary<string, Food> productMap)
        {
            Food productInfo = new Food(quantity);

            if (quantity <= 0)
            {
                return;
            }
            if (!productMap.ContainsKey(productName))
            {
                productMap.Add(productName, productInfo);
            }
            else
            {
                productMap[productName].Update(quantity);
            }
        }
    }
    class Food
    {

        public int Quantity { get; set; }
        public Food(int quantity)
        {
            Quantity = quantity;
        }
        public void Update(int quantity)
        {
            Quantity += quantity;
        }
    }
}
