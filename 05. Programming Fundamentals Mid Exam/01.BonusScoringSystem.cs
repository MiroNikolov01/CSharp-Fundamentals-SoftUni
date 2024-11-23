namespace _01.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            float maxBonus = 0;
            float currentAttendance = 0;
            if (lectures > 0 && students > 0)
            {
                for (int i = 1; i <= students; i++)
                {

                    float studentAttendances = int.Parse(Console.ReadLine());
                    float totalBonus = (float)(studentAttendances / lectures) * (5 + additionalBonus);
                    if (totalBonus > maxBonus)
                    {
                        maxBonus = totalBonus;
                        currentAttendance = studentAttendances;
                    }
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {currentAttendance} lectures.");


        }
    }
}







