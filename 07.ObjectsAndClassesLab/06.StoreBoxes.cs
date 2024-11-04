namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = null;
            List<Box> itemsInBox = new List<Box>();
            while ((cmd = Console.ReadLine()) != "end")
            {
                string[] properties = cmd.Split();

                int serialNumber = int.Parse(properties[0]);
                string itemName = properties[1];
                int itemQuantity = int.Parse(properties[2]);
                decimal itemPrice = decimal.Parse(properties[3]);

                Box boxProps = new Box()
                {
                    SerialNumber = serialNumber,
                    ItemName = itemName,
                    ItemQuantity = itemQuantity,
                    PriceBox = itemPrice,
                    TotalPrice = itemPrice * itemQuantity
                };

                itemsInBox.Add(boxProps);

            }
            List<Box> sortedBox = itemsInBox.OrderByDescending(boxes => boxes.TotalPrice).ToList();

            foreach (Box box in sortedBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.ItemName} - ${box.PriceBox:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.TotalPrice:f2}");
            }
        }
        class Box
        {
            public int SerialNumber { get; set; }
            public string ItemName { get; set; }
            public int ItemQuantity { get; set; }
            public decimal PriceBox { get; set; }
            public decimal TotalPrice { get; set; }

        }
    }
}








