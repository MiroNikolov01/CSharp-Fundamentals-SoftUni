namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputS = Console.ReadLine();
            int inputNum = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(inputS, inputNum));
        }
        static string RepeatString(string input, int addTimes)
        {
            string outPut = input;
            for (int i = 1; i < addTimes; i++)
            {
                outPut += input;
            }
            return outPut;
        }
    }
}
