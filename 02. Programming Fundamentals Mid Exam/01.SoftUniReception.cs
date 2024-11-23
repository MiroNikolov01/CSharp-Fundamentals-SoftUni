namespace _01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            const int employees = 3;
            int staffEfficiency = 0;
            for (int i = 0; i < employees; i++)
            {
                staffEfficiency += int.Parse(Console.ReadLine());
            }
            int studentsCount = int.Parse(Console.ReadLine());
            while (studentsCount > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                studentsCount -= staffEfficiency;

            }
            Console.WriteLine($"Time needed: {hours}h.");



        }

    }
}
