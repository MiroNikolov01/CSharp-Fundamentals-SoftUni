namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> userInfo = new List<User>();
            string info;
            while ((info = Console.ReadLine()) != "End")
            {
                string[] information = info.Split();
                string name = information[0];
                int id = int.Parse(information[1]);
                int age = int.Parse(information[2]);
                User user = new User(name, id, age);
                userInfo.Add(user);
            }
            var orderderInfoByAge = userInfo.OrderBy(u => u.Age);
            foreach (User userr in orderderInfoByAge)
            {
                Console.WriteLine($"{userr.Name} with ID: {userr.ID} is {userr.Age} years old.");
            }
        }
    }
    class User
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
        public User(string name, int id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
    }
}


