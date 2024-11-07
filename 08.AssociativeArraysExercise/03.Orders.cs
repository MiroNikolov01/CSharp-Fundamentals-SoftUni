

/*
Beer 2.40 350
Water 1.25 200
IceTea 5.20 100
Beer 1.20 200
IceTea 0.50 120
buy
 */

namespace GameOfNaturalForces
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, Product> productsMap = new();
            string cmd;
            while ((cmd = Console.ReadLine()) != "buy")
            {
                string[] productInfo = cmd.Split();
                string productName = productInfo[0];
                decimal productPrice = decimal.Parse(productInfo[1]);
                int productQuantity = int.Parse(productInfo[2]);

                if (!productsMap.ContainsKey(productName))
                {
                    Product products = new Product(productName, productPrice, productQuantity);
                    productsMap.Add(products.Name,products);
                }
                else
                {
                    productsMap[productName].Update(productPrice, productQuantity);
                }



            }
                foreach ( var product in productsMap.Values)
                {
                Console.WriteLine(product.ToString());
                }

        }
    }
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Price * Quantity;
        public Product(string name,decimal price,int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public void Update(decimal price, int quantity)
        {
            Price = price;
            Quantity += quantity;
        }
        public override string ToString()
        {
            return $"{Name} -> {TotalPrice:F2}"; 
        }


    }
}

