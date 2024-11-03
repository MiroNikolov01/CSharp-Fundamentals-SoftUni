namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (CorespondingMessageTrue(password))
            {
                Console.WriteLine("Password is valid");
            }
            if (CorespondingBetweenChar(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (CorespondingLettersAndDigits(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (CorespondingTwoDigits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
        static bool CorespondingMessageTrue(string password)
        {
            return (ContainInclusive(password) == "isValid" &&
                ContainLettersAndDigits(password) == "isValid" &&
                AtleastTwoDigits(password) == "isValid");
        }
        static bool CorespondingTwoDigits(string isValid)
        {
            return AtleastTwoDigits(isValid) == "isValid";
        }
        static bool CorespondingLettersAndDigits(string isValid)
        {
            return ContainLettersAndDigits(isValid) == "isValid";
        }
        static bool CorespondingBetweenChar(string isValid)
        {
            return ContainInclusive(isValid) == "isValid";
        }
        static string ContainInclusive(string input)
        {
            string res = string.Empty;
            if (input.Length >= 6 && input.Length <= 10)
            {
                res = "isValid";
            }
            return res;
        }
        static string ContainLettersAndDigits(string input)
        {
            string res = string.Empty;
            bool isValid = input.All(char.IsLetterOrDigit);
            if (isValid)
            {
                res = "isValid";
            }
            return res;

        }
        static string AtleastTwoDigits(string input)
        {
            string res = string.Empty;
            int digitCount = input.Count(char.IsDigit);
            if (digitCount >= 2)
            {
                res = "isValid";
            }
            return res;
        }
    }
}

