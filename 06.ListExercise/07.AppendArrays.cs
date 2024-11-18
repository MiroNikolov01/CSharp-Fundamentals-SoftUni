namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string arrString = Console.ReadLine();
            char[] delimiters = { '|' };
            string[] splitResult = arrString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            string[] result = new string[splitResult.Length];

            int index = 0;
            for (int i = splitResult.Length - 1; i >= 0; i--)
            {
                result[index] += splitResult[i];
                index++;
            }

            string output = string.Join(" ", string.Join(" ", result).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            Console.WriteLine(output);



        }
    }
}


