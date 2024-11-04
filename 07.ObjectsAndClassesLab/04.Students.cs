namespace _04.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> studentsInfo = new List<Student>();
            string information = string.Empty;
            while ((information = Console.ReadLine()) != "end")
            {
                string[] arguments = information.Split();

                string firstName = arguments[0];
                string lastName = arguments[1];
                int age = int.Parse(arguments[2]);
                string city = arguments[3];

                Student students = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };
                studentsInfo.Add(students);
            }
            string cityCommand = Console.ReadLine();
            List<Student> filteredStudents = studentsInfo.Where(s => s.City == cityCommand).ToList();
            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
    }
}








