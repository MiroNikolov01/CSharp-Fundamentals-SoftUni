
using System.Linq;
using System.Text;

namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string decodeCommands;
            while ((decodeCommands = Console.ReadLine()) != "Decode")
            {
                string[] tokens = decodeCommands.Split("|");
                switch (tokens[0])
                {
                    case "Move":
                        encryptedMessage = Move(encryptedMessage, int.Parse(tokens[1]));
                        break;
                    case "Insert":
                        encryptedMessage = Insert(encryptedMessage, int.Parse(tokens[1]), tokens[2]);
                        break;
                    case "ChangeAll":
                        encryptedMessage = ChangeAll(encryptedMessage, tokens[1], tokens[2]);

                        break;
                }
            }
            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }

        private static string Move(string encryptedMessage, int numberOfLetters)
        {
            string letters = encryptedMessage.Substring(0,numberOfLetters);
            encryptedMessage = encryptedMessage.Remove(0, numberOfLetters);
            encryptedMessage = encryptedMessage.Insert(encryptedMessage.Length,letters);

            return encryptedMessage;
        }

        private static string Insert(string encryptedMessage, int index, string value)
        {
            encryptedMessage = encryptedMessage.Insert(index, value);
            return encryptedMessage;
        }
        private static string ChangeAll(string encryptedMessage, string substring, string replacement)
        {
           StringBuilder sb = new StringBuilder(encryptedMessage);
            sb.Replace(substring, replacement);

            return encryptedMessage = sb.ToString();
        }

    }
}



