namespace _02.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int countPersons = int.Parse(Console.ReadLine());

            for (int i = 0; i < countPersons; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person person = new Person(name, age);
                family.AddMember(person);

            }
            Person oldest = family.GetOldestMemeber();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");

        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Family
    {
        public List<Person> members { get; set; } = new List<Person>();
        public void AddMember(Person member)
        {
            members.Add(member);
        }
        public Person GetOldestMemeber()
        {
            return members.OrderByDescending(m => m.Age).FirstOrDefault();
        }
    }
    
}