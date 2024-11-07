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
                reversedString = new string(cmd.Reverse().ToArray());
                Console.WriteLine($"{currentString} = {reversedString}");
            }
        }
    }
}
