namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string product = Console.ReadLine();
             decimal quantity = decimal.Parse(Console.ReadLine());
            OrderProcess(product,quantity);
        }
        static void OrderProcess(string product, decimal quantity)
        {
             switch (product)
             {
                case "coffee": quantity *= 1.5m;
                    break;
                case "water":
                    quantity *= 1.0m;
                    break;
                case "coke":
                    quantity *= 1.40m;
                    break;
                case "snacks":
                    quantity *= 2.0m;
                    break;
            }
                    Console.WriteLine($"{quantity:F2}");

        }
    }
}
