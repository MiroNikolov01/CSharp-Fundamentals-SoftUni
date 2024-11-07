namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd;
            while ((cmd = Console.ReadLine()) != "end")
            {
                string reversedString = "";
                string currentString = cmd;
                char[] charArray = cmd.ToCharArray();
                Array.Reverse(charArray);
                for (int i = 0; i < charArray.Length; i++)
                {
                    reversedString += charArray[i];
                }
                Console.WriteLine($"{currentString} = {reversedString}");
            }
        }
    }
}
