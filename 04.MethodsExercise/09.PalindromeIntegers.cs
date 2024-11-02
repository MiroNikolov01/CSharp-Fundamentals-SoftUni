namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string copyNum = command;
                Console.WriteLine(Palindrome(copyNum, command));
            }
        }
        static bool Palindrome(string copyNum, string command)
        {
            char[] numbers = command.ToCharArray();
            Array.Reverse(numbers);
            string stickStr = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                stickStr += numbers[i];
            }
            if (stickStr == copyNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

