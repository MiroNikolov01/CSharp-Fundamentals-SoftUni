namespace _05.ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] buyers = Console.ReadLine().Split(new char[] { ';', '=' });
            int totalbuyers = buyers.Length;
            List<Person> listPersons = new List<Person>();
            List<Product> listProducts = new List<Product>();
            for (int i = 0; i < totalbuyers; i++)
            {
                string name = buyers[i];
                i++;
                decimal budget = decimal.Parse(buyers[i]);
                Person person = new Person(name, budget);
                listPersons.Add(person);
            }
            string[] availableProducts = Console.ReadLine().Split(new char[] { '=', ';', });
            int totalProducts = availableProducts.Length;
            for (int i = 0; i < totalProducts; i++)
            {
                string nameOfProduct = availableProducts[i];
                i++;
                decimal priceOfProduct = decimal.Parse(availableProducts[i]);
                Product product = new Product(nameOfProduct, priceOfProduct);
                listProducts.Add(product);
            }
            string buyingProducts;
            while ((buyingProducts = Console.ReadLine()) != "END")
            {
                string[] purchase = buyingProducts.Split();
                string name = purchase[0];
                string product = purchase[1];

                Person listPerson = listPersons.FirstOrDefault(n => n.Name == name);
                Product listProduct = listProducts.FirstOrDefault(n => n.Name == product);

                if (listPerson.Budget >= listProduct.Price)
                {
                    listPerson.Products.Add(product);
                    listPerson.Budget -= listProduct.Price;
                    Console.WriteLine($"{name} bought {listProduct.Name}");

                }
                else
                {
                    Console.WriteLine($"{name} can't afford {listProduct.Name}");
                }

            }
            foreach (var emptyList in listPersons.Where(l => l.Products.Count == 0))
            {
                Console.WriteLine($"{emptyList.Name} - Nothing bought");
            }
            foreach (var list in listPersons.Where(p => p.Products.Count > 0))
            {
                Console.WriteLine($"{list.Name} - {string.Join(", ", list.Products)}");
            }

        }

    }
    class Person
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public List<string> Products { get; set; } = new List<string>();
        public Person(string name, decimal budget)
        {
            Name = name;
            Budget = budget;
        }

    }
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
       
        public void CanAfford(Person name, Product product)
        {

        }
    }
}
