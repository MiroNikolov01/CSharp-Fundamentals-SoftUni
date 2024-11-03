namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbersInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(' ');
                switch (arguments[0])
                {
                    case "exchange":
                        int index = int.Parse(arguments[1]);
                        arrayNumbersInput = ExchangeProcess(arrayNumbersInput, index);
                        break;
                    case "max":
                        string maxType = arguments[1];
                        MaxEvenOrOdd(arrayNumbersInput, maxType);
                        break;
                    case "min":
                        string minType = arguments[1];
                        MinEvenOdd(arrayNumbersInput, minType);
                        break;
                    case "first":
                        int firstCount = int.Parse(arguments[1]);
                        string firstType = arguments[2];
                        FirstCountEvenOrOdd(arrayNumbersInput, firstCount, firstType);
                        break;
                    case "last":
                        int lastCount = int.Parse(arguments[1]);
                        string lastType = arguments[2];
                        LastCountEvenOrOdd(arrayNumbersInput, lastCount, lastType);
                        break;

                }


            }
            Console.WriteLine($"[{string.Join(", ", arrayNumbersInput)}]");
        }

        static int[] ExchangeProcess(int[] array, int numberIndex)
        {
            if (!ValidIndex(numberIndex, array.Length - 1))
            {
                Console.WriteLine("Invalid index");
                return array;
            }
            int[] changedArray = new int[array.Length];
            int changedIndex = 0;
            for (int i = numberIndex + 1; i <= array.Length - 1; i++)
            {
                changedArray[changedIndex] = array[i];
                changedIndex++;
            }
            for (int i = 0; i <= numberIndex; i++)
            {
                changedArray[changedIndex] = array[i];
                changedIndex++;
            }

            return changedArray;
        }
        static void MaxEvenOrOdd(int[] array, string type)
        {
            int indexChanged = -1;
            int maxNumber = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                if (OddOrEven(type, number))
                {
                    if (number >= maxNumber)
                    {
                        maxNumber = number;
                        indexChanged = i;
                    }
                }
            }
            PrintIfValid(indexChanged);
        }
        static void MinEvenOdd(int[] array, string type)
        {
            int indexChanged = -1;
            int minNumber = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                if (OddOrEven(type, number))
                {
                    if (number <= minNumber)
                    {
                        minNumber = number;
                        indexChanged = i;
                    }
                }
            }
            PrintIfValid(indexChanged);
        }
        static void FirstCountEvenOrOdd(int[] array, int count, string type)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string printNumbers = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                if (OddOrEven(type, number))
                {
                    printNumbers += number + ", ";
                    count--;
                    if (count <= 0)
                    {
                        break;
                    }
                }
            }
            printNumbers = printNumbers.Trim(' ', ',');
            Console.WriteLine($"[{printNumbers}]");
        }
        static void LastCountEvenOrOdd(int[] array, int count, string type)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string printNumbers = string.Empty;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int number = array[i];
                if (OddOrEven(type, number))
                {
                    printNumbers = $"{number}, " + printNumbers;
                    count--;
                    if (count <= 0)
                    {
                        break;
                    }
                }
            }
            printNumbers = printNumbers.Trim(' ', ',');
            Console.WriteLine($"[{printNumbers}]");
        }
        static void PrintIfValid(int index)
        {
            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static bool OddOrEven(string oddOrEvenType, int oddOrEvenIndex)
        {
            return (oddOrEvenType == "even" && oddOrEvenIndex % 2 == 0 || oddOrEvenType == "odd" && oddOrEvenIndex % 2 != 0);
        }
        static bool ValidIndex(int validIndex, int lastIndex)
        {

            return validIndex >= 0 && validIndex <= lastIndex;
        }

    }
}