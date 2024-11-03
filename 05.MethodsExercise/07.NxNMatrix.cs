namespace _07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            NxNMatrix(n);
        }
        static void NxNMatrix(int n)
        {
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
