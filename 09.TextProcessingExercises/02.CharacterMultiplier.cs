namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine().Split();
            string firstUnput = stringArray[0];
            string secondInpit = stringArray[1];
            int result = StringMultiplier(firstUnput, secondInpit);
            Console.WriteLine(result);
        }
        static int StringMultiplier(string firstSrt, string secondStr)
        {
            int result = 0;

            int minLength = Math.Min(firstSrt.Length, secondStr.Length);
            int maxLength = Math.Max(secondStr.Length, firstSrt.Length);


            for (int i = 0; i < minLength; i++)
            {
                result += firstSrt[i] * secondStr[i];
            }

            string longestString = firstSrt.Length > secondStr.Length ? firstSrt : secondStr;

            for (int i = minLength; i < maxLength; i++)
            {
                result += longestString[i];
            }
            return result;
        }
    }
}

