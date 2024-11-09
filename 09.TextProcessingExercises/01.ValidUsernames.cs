namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            string[] validUsernames = new string[usernames.Length];
            ValidUsername(usernames, validUsernames);


        }
        static void ValidUsername(string[] username, string[] valid)
        {
            bool isAlphanumeric = false;
            for (int i = 0; i < username.Length; i++)
            {

                isAlphanumeric = username[i].All(char.IsLetterOrDigit);

                if (username[i].Contains("-") ||
                    username[i].Contains("_") ||
                    isAlphanumeric)
                {
                    if (username[i].Length >= 3 &&
                    username[i].Length <= 16)
                    {
                        valid[i] = username[i];

                    }
                }

            }
            var cleanedUsesrnames = valid.Where(c => c != null);
            foreach (var usernames in cleanedUsesrnames)
            {
                Console.WriteLine(usernames);
            }
        }

    }
}
