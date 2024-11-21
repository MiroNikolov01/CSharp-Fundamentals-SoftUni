using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace _03.TresureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int intLength = intArr.Length - 1;
            
            string tresureSearch;
            while ((tresureSearch = Console.ReadLine()) != "find")
            {
                int intIterator = 0;
                char[] charArr = tresureSearch.ToCharArray();
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (intIterator > intLength)
                    {
                        intIterator = 0;
                    }
                    charArr[i] -= (char)intArr[intIterator];
                    intIterator++;
                }
                StringBuilder sb = new StringBuilder();
                for (int i = 0; (i < charArr.Length); i++)
                {
                    sb.Append(charArr[i]);
                }
               
                int startType = sb.ToString().IndexOf('&') + 1;
                int endType = sb.ToString().IndexOf('&', startType + 1);

                string type = sb.ToString().Substring(startType, endType - startType);

                int startCoordinates = sb.ToString().IndexOf('<') + 1;
                int endCoordinates = sb.ToString().IndexOf('>');

                string coordinates = sb.ToString().Substring(startCoordinates, endCoordinates - startCoordinates);
                Console.WriteLine($"Found {type} at {coordinates}");



            }


        }
    }
}
