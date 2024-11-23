namespace _02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] copyArrays = new int[arrayNums.Length];
            for (int i = 0; i < arrayNums.Length; i++)
            {
                copyArrays[i] = arrayNums[i];
            }
            string cmd = string.Empty;
            while ((cmd = Console.ReadLine()) != "end")
            {
                string[] tokens = cmd.Split();
                int index1 = 0;
                int index2 = 0;

                switch (tokens[0])
                {
                    case "swap":
                        index1 = int.Parse(tokens[1]);
                        index2 = int.Parse(tokens[2]);
                        if (IsValidIndex(arrayNums, index1, index2))
                        {
                            Swap(arrayNums, index1, index2);
                        }
                        break;
                    case "multiply":
                        index1 = int.Parse(tokens[1]);
                        index2 = int.Parse(tokens[2]);
                        if (IsValidIndex(arrayNums, index1, index2))
                        {
                            Multiply(arrayNums, index1, index2);
                        }
                        break;
                    case "decrease":
                        Decrease(arrayNums);
                        break;
                }

            }
            if (arrayNums != copyArrays)
            {
                Console.WriteLine(string.Join(", ", arrayNums), StringSplitOptions.RemoveEmptyEntries);
            }
        }
        static void Swap(int[] arr, int index1, int index2)
        {
            int copyElementOne = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = copyElementOne;
        }
        static void Multiply(int[] arr, int index1, int index2)
        {
            int result = arr[index1] * arr[index2];
            arr[index1] = result;
        }
        static void Decrease(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]--;
            }
        }
        static bool IsValidIndex(int[] arr, int index1, int index2)
        {
            bool isValid = false;
            if (index1 >= 0 && index1 <= arr.Length - 1)
            {
                if (index2 >= 0 && index2 <= arr.Length - 1)
                {
                    isValid = true;
                }
            }

            return isValid;
        }
    }
}
