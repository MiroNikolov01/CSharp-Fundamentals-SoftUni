using Microsoft.VisualBasic;

namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gradeInput = double.Parse(Console.ReadLine());
            GradeDefinition(gradeInput);
        }
        static void GradeDefinition(double num)
        {
            string grade = String.Empty;
            if (num is >= 2.00 and <= 2.99)
            {
                grade = "Fail";
            }
            else if (num is >= 3.00 and <= 3.39)
            {
                grade = "Poor";
            }
            else if (num is >= 3.50 and <= 4.49)
            {
                grade = "Good";
            }
            else if (num is >= 4.50 and <= 5.49)
            {
                grade = "Very good";
            }
            else if (num is >= 5.50 and <= 6.00)
            {
                grade = "Excellent";
            }

            Console.WriteLine(grade);
        }
    }
}