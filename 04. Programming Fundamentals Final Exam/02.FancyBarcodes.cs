using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullPattern = @"@[#]+(?<barcode>[A-Z][A-Za-z0-9]+[A-Z])@[#]+";
            int coundBarcodes = int.Parse(Console.ReadLine());
            for (int i = 0; i < coundBarcodes; i++)
            {
                string inputBarcode = Console.ReadLine();
                string isValidBarcode = Regex.Match(inputBarcode, fullPattern).Groups["barcode"].Value;

                if (isValidBarcode == "" || isValidBarcode.Length < 6)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                string productGroup = string.Concat(isValidBarcode.Where(char.IsDigit));

                if (string.IsNullOrEmpty(productGroup))
                {
                    productGroup = "00";
                }
                Console.WriteLine($"Product group: {productGroup}");
            }
        }
    }
}
