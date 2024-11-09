namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pathFile = Console.ReadLine()
                .Split(new string[] { ".", "\\" }, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(pathFile);

            Console.WriteLine($"File name: {pathFile[1]}");
            Console.WriteLine($"File extension: {pathFile[0]}");
        }
    }
}
