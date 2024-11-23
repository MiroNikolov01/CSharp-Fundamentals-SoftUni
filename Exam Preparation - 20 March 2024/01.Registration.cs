
using System.Text;

namespace _01.Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string inputUsername = Console.ReadLine();
            string copyInput = inputUsername;
            string cmd;
            string username = inputUsername;
            while ((cmd = Console.ReadLine()) != "Registration")
            {
                string[] arguments = cmd.Split();
                switch (arguments[0])
                {
                    case "Letters":
                        string reversed = string.Empty;
                        switch (arguments[1])
                        {
                            case "Lower":
                                foreach (char l in username)
                                {
                                    reversed += char.ToLower(l);
                                }
                                break;
                            case "Upper":
                                foreach (char u in username)
                                {
                                    reversed += char.ToUpper(u);
                                }
                                break;

                        }
                        username = reversed;
                        Console.WriteLine(username);
                        break;
                    case "Reverse":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);
                        if (startIndex >= 0 && startIndex <= username.Length - 1 &&
                            endIndex >= 0 && endIndex <= username.Length - 1)
                        {
                            string substringUser = username.Substring(startIndex, endIndex - startIndex + 1);
                            string reversedUser = new string(substringUser.Reverse().ToArray());
                            Console.WriteLine(reversedUser);
                        }
                        break;
                    case "Substring":
                        string substring = arguments[1];
                        StringBuilder substringBuilder = new StringBuilder(username);
                        if (!username.Contains(substring))
                        {
                            Console.WriteLine($"The username {username} doesn't contain {substring}.");
                            break;
                        }
                        while (substringBuilder.ToString().Contains(substring))
                        {
                            substringBuilder.Replace(substring, "");
                        }
                        username = substringBuilder.ToString();
                        Console.WriteLine(username);
                        break;
                    case "Replace":
                        char element = char.Parse(arguments[1]);
                        StringBuilder replaceBuilder = new StringBuilder(username);
                        if (!username.Contains(element))
                        {
                            Console.WriteLine($"{element} must be contained in your username.");
                            break;
                        }
                        while (replaceBuilder.ToString().Contains(element))
                        {
                            replaceBuilder.Replace(element, '-');
                        }
                        username = replaceBuilder.ToString();
                        Console.WriteLine(username);
                        break;
                    case "IsValid":
                        char symbol = char.Parse(arguments[1]);
                        if (!username.Contains(symbol))
                        {
                            Console.WriteLine($"{symbol} must be contained in your username.");
                            break;
                        }
                        Console.WriteLine("Valid username.");
                        break;
                }
            }
        }
    }
}
