namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleCharacter(input);
        }
        static void MiddleCharacter(string input)
        {
            {
                if (input.Length % 2 != 0)
                {
                    Console.WriteLine(input[(input.Length - 1) / 2]);
                }
                else
                {
                    Console.Write(input[(input.Length / 2) - 1]);
                    Console.Write(input[input.Length / 2]);
                    {

                    }
                }
            }
        }
    }
}


