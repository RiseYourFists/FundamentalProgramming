using System;
using System.Collections.Generic;

namespace Articles2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;

        }

        public Article()
        {
            this.Collection = new List<Article>();
        }

        public List<Article> Collection { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var newArticles = new Article();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                var title = input[0];
                var content = input[1];
                var author = input[2];

                var newArticle = new Article(title, content, author);
                newArticles.Collection.Add(newArticle);
            }

            foreach (var item in newArticles.Collection)
            {
                Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
            }
        }
    }
}
