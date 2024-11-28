namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string commands;
            while ((commands = Console.ReadLine()) != "Done")
            {
                string[] arguments = commands.Split
                    (' ', StringSplitOptions.RemoveEmptyEntries);
                switch (arguments[0])
                {
                    case "TakeOdd":
                        password = TakeOdd(password);
                        break;
                    case "Cut":
                        int index = int.Parse(arguments[1]);
                        int lenght = int.Parse(arguments[2]);
                        password = Cut(password,index,lenght);
                        break;
                    case "Substitute":
                        string substring = arguments[1];
                        string substitute = arguments[2];
                        string currentPassword = password;
                        password = Substitute(password, substring, substitute);
                        if (currentPassword == password)
                        {
                            continue;
                        }
                            break;
                }
                Console.WriteLine(password);
            }
            Console.WriteLine($"Your password is: {password}");
        }

        private static string Substitute(string password, string substring, string substitute)
        {
            if (!password.Contains(substring))
            {
                Console.WriteLine("Nothing to replace!");
                return password;
            }
            password = password.Replace(substring, substitute);

            return password;
        }

        private static string Cut(string password,int index,int length)
        {
            string substring = password.Substring(index, length);
            int startIndex = password.IndexOf(substring);

            password = password.Remove(startIndex, length);

            return password;
        }

        private static string TakeOdd(string password)
        {
            string oddChars = null;
            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddChars += password[i];
                }
            }

            return oddChars;
        }
    }
}
