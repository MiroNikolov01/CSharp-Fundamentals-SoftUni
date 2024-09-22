int n = int.Parse(Console.ReadLine());
int currentNum = 0;
for (int rows = 1; rows <= n; rows++)
{
    for (int cols = 1; cols <= rows; cols++)
    {
        Console.Write($"{rows} ");
    }
    Console.WriteLine();
}