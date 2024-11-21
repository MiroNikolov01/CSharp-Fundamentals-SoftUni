using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> comments = new List<string>();

        string title = Console.ReadLine();
        string article = Console.ReadLine();

        string comment;

        while ((comment = Console.ReadLine()) != "end of comments")
        {
            comments.Add(comment);
        }

        Console.WriteLine("<h1>");
        Console.WriteLine($"    {title}");
        Console.WriteLine("</h1>");

        Console.WriteLine("<article>");
        Console.WriteLine($"    {article}");
        Console.WriteLine($"</article>");

        for (int i = 0; i < comments.Count; i++)
        {
            Console.WriteLine("<div>");
            Console.WriteLine($"    {comments[i]}");
            Console.WriteLine("</div>");
        }
    }
}