namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> information = new List<Student>();

            int input = int.Parse(Console.ReadLine());


            for (int i = 0; i < input; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string firstName = arguments[0];
                string lastName = arguments[1];
                double grade = double.Parse(arguments[2]);
                Student student = new Student(firstName, lastName, grade);
                information.Add(student);
            }
            var sortedInformation = information.OrderByDescending(s => s.Grade).ToList();

            foreach (Student students in sortedInformation)
            {
                Console.WriteLine($"{students.FirstName} {students.LastName}: {students.Grade:F2}");
            }

        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

    }
}












