namespace _03.Articles2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Articles> article = new List<Articles>();

            int nInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < nInput; i++)
            {
                string[] arguments = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string title = arguments[0];
                string content = arguments[1];
                string author = arguments[2];
                Articles articles = new Articles(title, content, author);
                article.Add(articles);
            }
            foreach (Articles argument in article)
            {
                Console.WriteLine(argument.ToString());
            }
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
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }



    }
}










