using System.Text;

namespace LargeNumberMultiplier
{
    class Program
    {
        //WorkInProgres!!
        static void Main(string[] args)
        {
            string bigNumberInput = Console.ReadLine();
            string multiplyNumber = Console.ReadLine();
           
            string result = MultiplyLargeNumber(bigNumberInput, multiplyNumber);
            Console.WriteLine(result);
        }

        static string MultiplyLargeNumber(string number, string multiplierStr)
        {
            if (number == "0" || multiplierStr == "0")
            {
                return "0";
            }
            int carry = 0;
            char[] charResult = new char[number.Length + 1];
            int multiplier = int.Parse(multiplierStr);

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';
                int product = digit * multiplier + carry;

               charResult[i + 1] = (char)(product % 10 + '0');
                carry = product / 10;
            }
            
            if (carry > 0)
            {
                charResult[0] = (char)(carry + '0');
            }
            return new string (charResult).TrimStart('\0');

        }
    }
}
