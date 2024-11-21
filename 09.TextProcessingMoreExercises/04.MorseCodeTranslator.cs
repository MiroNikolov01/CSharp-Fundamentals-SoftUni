namespace _04.MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseMap = new();
            string morseCodeAlphabet = ".- -... -.-. -.. . ..-. --. .... .. .--- -.- .-.. -- -. --- .--. --.- .-. ... - ..- ...- .-- -..- -.-- --..";
            string[] morseCodes = morseCodeAlphabet.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            int alphabetIterator = 0;
            for (int i = 0; i < morseCodes.Length; i++)
            {
                if (!morseMap.ContainsKey(morseCodes[i]))
                {
                    morseMap[morseCodes[i]] = (char)('A' + alphabetIterator);
                    alphabetIterator++;
                }
            }
            morseMap["|"] = ' ';

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string translatedMessage = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                foreach (var letter in morseMap)
                {
                    if (input[i] == letter.Key)
                    {
                        translatedMessage += letter.Value;
                    }
                }
            }
            Console.WriteLine(translatedMessage);
           
        }
    }
}

