using System.Diagnostics;

namespace _05.StudentAcademy
{
    /*
5
Amanda
3.5
Amanda
4
Rob
5.5
Christian
5
Robert
6
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> studentInfo = new();
            int students = int.Parse(Console.ReadLine());
            int countGrade = 1;
            for (int i = 0; i < students; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentInfo.ContainsKey(name))
                {
                    Student student = new Student(name, grade);
                    studentInfo.Add(student.StudentName, student);
                    student.Count = 1;
                }
                else
                {
                    studentInfo[name].Update(grade, countGrade);

                }

            }
            foreach (Student student in studentInfo.Values)
            {
                double grade = student.Grade;
                double average = student.Average(student.Count, grade);
                if (average >= 4.50)
                {
                    Console.WriteLine(student.ToString());
                }
                


            }

        }
    }
    class Student
    {
        public string StudentName { get; set; }
        public double Grade { get; set; }
        public int Count { get; set; }
        public double AverageGrade { get; set; }
        public Student(string studentName, double grade)
        {
            StudentName = studentName;
            Grade = grade;
        }
        public void Update(double grade,int count)
        {
            Grade += grade;
            Count += count;
        }
        public double Average(int count, double totalSumGrades)
        {
            double averageSum = totalSumGrades / count;
            AverageGrade = averageSum;
           return averageSum;
        }
        public override string ToString()
        {
            return $"{StudentName} -> {AverageGrade:F2}";
        }

    }
}
