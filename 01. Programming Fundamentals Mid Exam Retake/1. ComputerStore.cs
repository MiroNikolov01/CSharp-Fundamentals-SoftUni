namespace _01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string prices = string.Empty;
            double totalPrice = 0.0;
            double inputPrice = 0;
            while ((prices = Console.ReadLine()) != "special" && prices != "regular")
            {
                inputPrice = double.Parse(prices);
                if (inputPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                else if (inputPrice == 0)
                {
                    Console.WriteLine("Invalid order!");
                    continue;
                }
                totalPrice += inputPrice;
            }
            if (totalPrice <= 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            double tax = totalPrice * 0.20;
            double noTaxPrice = totalPrice;
            totalPrice += tax;

            switch (prices)
            {
                case "special":
                    totalPrice *= 0.90;
                    break;

            }
            Console.WriteLine($"Congratulations you've just bought a new computer!\nPrice without taxes: {noTaxPrice:F2}$\nTaxes: {tax:F2}$\n-----------\nTotal price: {totalPrice:F2}$");

        }

    }
}
