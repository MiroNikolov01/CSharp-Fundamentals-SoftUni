namespace _04.SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userInfo = new();
            int users = int.Parse(Console.ReadLine());
            for (int i = 0; i < users; i++)
            {
                string[] arguments = Console.ReadLine().Split();

                string command = arguments[0];
                string username = arguments[1];
                

                switch (command)
                {
                    case "register":
                            string licensePlate = arguments[2];
                        if (!userInfo.ContainsKey(username))
                        {

                            userInfo[username] = licensePlate;
                            Console.WriteLine($"{username} registered {licensePlate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                        break;
                    case "unregister":
                        if (!userInfo.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            userInfo.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        break;
                }

            }
            foreach (var user in userInfo)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
