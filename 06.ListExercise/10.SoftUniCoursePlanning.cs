namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitArray = input.Split(new string[] { ", " }, StringSplitOptions.None);

            List<string> lessonTitlesList = new List<string>(splitArray);

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] arguments = command.Split(new string[] { ":" }, StringSplitOptions.None);

                switch (arguments[0])
                {
                    case "Add":
                        string addTitle = arguments[1];
                        AddMethod(lessonTitlesList, addTitle);
                        break;
                    case "Insert":
                        int indexInsert = int.Parse(arguments[2]);
                        string insertTitle = arguments[1];
                        if (!isValidIndex(lessonTitlesList, indexInsert))
                        {
                            InsertMethod(lessonTitlesList, indexInsert, insertTitle);
                        }
                        break;
                    case "Remove":
                        string removeTitle = arguments[1];
                        RemoveMethod(lessonTitlesList, removeTitle);
                        break;
                    case "Swap":
                        string swapOne = arguments[1];
                        string swapTwo = arguments[2];
                        SwapMethod(lessonTitlesList, swapOne, swapTwo);
                        break;
                    case "Exercise":
                        string title = arguments[1];
                        ExercisesMethod(lessonTitlesList, title);
                        break;
                }
            }
            int index = 1;

            foreach (var title in lessonTitlesList)
            {
                Console.WriteLine($"{index++}.{title}");
            }

        }
        static void AddMethod(List<string> list, string lessonTitle)
        {
            if (!ContainsTitle(list, lessonTitle))
            {
                list.Add(lessonTitle);
            }
        }
        static void InsertMethod(List<string> list, int index, string insertTitle)
        {
            if (!ContainsTitle(list, insertTitle))
            {
                list.Insert(index, insertTitle);
            }
        }
        static void RemoveMethod(List<string> list, string removeTitle)
        {
            if (ContainsTitle(list, removeTitle))
            {
                list.Remove(removeTitle);
            }
            if (list.Contains($"{removeTitle}-Exercise"))
            {
                list.Remove($"{removeTitle}-Exercise");
            }

        }
        static List<string> SwapMethod(List<string> list, string swapLeft, string swapRight)
        {
            int indexOne = list.IndexOf(swapLeft);
            int indexTwo = list.IndexOf(swapRight);
            if (list.Contains(swapLeft) && list.Contains(swapRight))
            {
                list.Insert(indexTwo, swapLeft);
                list.RemoveAt(indexTwo + 1);

                list.Insert(indexOne, swapRight);
                list.RemoveAt(indexOne + 1);

                if (list.Contains(swapLeft + "-Exercise") && list.Contains(list[indexOne]))
                {
                    indexOne = list.IndexOf(swapLeft);
                    list.Remove(swapLeft + "-Exercise");
                    list.Insert(indexOne + 1, swapLeft + "-Exercise");
                }
                else if (list.Contains(swapRight + "-Exercise") && list.Contains(list[indexTwo]))
                {
                    indexTwo = list.IndexOf(swapRight);
                    list.Remove(swapRight + "-Exercise");
                    list.Insert(indexTwo + 1, swapRight + "-Exercise");
                }

            }
            return list;
        }
        static void ExercisesMethod(List<string> list, string title)
        {
            if (!ContainsTitle(list, title))
            {
                list.Add(title);
                list.Add(title += "-Exercise");
            }
            else if (ContainsTitle(list, title) && !ContainsTitle(list, $"{title}-Exercise"))
            {
                int index = list.IndexOf(title);
                list.Insert(index + 1, $"{title}-Exercise");
            }
        }

        static bool isValidIndex(List<string> list, int num)
        {
            return num < 0 && num > list.Count - 1;
        }
        static bool ContainsTitle(List<string> list, string title)
        {
            return list.Contains(title);
        }
    }

}






