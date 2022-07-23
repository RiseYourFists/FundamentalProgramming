using System;

namespace Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var newArticle = new Article(input[0], input[1], input[2]);
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var action = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                var editType = action[0];
                var content = action[1];
                switch (editType)
                {
                    case "Edit":
                        newArticle.Edit(content);
                        break;
                    case "ChangeAuthor":
                        newArticle.ChangeAuthor(content);
                        break;
                    case "Rename":
                        newArticle.Rename(content);
                        break;
                }
            }

            Console.WriteLine($"{newArticle.Title} - {newArticle.Content}: {newArticle.Author}");
        }
    }
}
