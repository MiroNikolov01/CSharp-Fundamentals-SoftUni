using System.Text;

namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string cmd;
            while ((cmd = Console.ReadLine()) != "Reveal")
            {
                string[] arguments = cmd.Split(":|:");
                string substring = arguments[1];
                switch (arguments[0])
                {
                    case "InsertSpace":
                        int index = int.Parse(arguments[1]);
                        message = InsertSpace(index, message);
                        break;
                    case "Reverse":
                        if (!message.Contains(substring))
                        {
                            Console.WriteLine("error");
                            break;
                        }
                        int indexSubstring = message.IndexOf(substring);
                        message = Reverse(indexSubstring, message, substring);


                        break;
                    case "ChangeAll":
                        string replacement = arguments[2];
                        message = ChangeAll(replacement, message, substring);
                        break;


                }
            }
            Console.WriteLine($"You have a new text message: {message}");

        }
        static string InsertSpace(int index, string message)
        {
            message = message.Insert(index, " ");
            Console.WriteLine(message);

            return message;
        }
        static string Reverse(int index, string message, string substring)
        {
            message = message.Remove(index, substring.Length);
            string reversedSubstring = new string(substring.Reverse().ToArray());
            message = message.Insert(message.Length, reversedSubstring);
            Console.WriteLine(message);

            return message;
        }
        static string ChangeAll(string replacement, string message, string substring)
        {
            StringBuilder sb = new StringBuilder(message);
            while (sb.ToString().Contains(substring))
            {
                sb.Replace(substring, replacement);
            }
            message = sb.ToString();
            Console.WriteLine(message);
            return message;
        }
    }
}
