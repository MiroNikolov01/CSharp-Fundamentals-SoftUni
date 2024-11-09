namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initialInput = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string initialTitle = initialInput[0];
            string initialContent = initialInput[1];
            string initialAuthor = initialInput[2];

            Articles article = new Articles(initialTitle, initialContent, initialAuthor);

            int nInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < nInput; i++)
            {
                string cmd = Console.ReadLine();
                string[] arguments = cmd.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                switch (arguments[0])
                {
                    case "Edit":
                        article.Edit(arguments[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(arguments[1]);
                        break;
                    case "Rename":
                        article.Rename(arguments[1]);
                        break;
                }

            }
            Console.WriteLine(article.ToString());
        }
    }
    class Articles
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }



    }
}










