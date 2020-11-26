using System;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Show();

        }
    }
    class Title
    {
        public string Ttl { get; set; }
        public void Show()
        {

            Title title = new Title();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(title.Ttl);
        }
    }
    class Author
    {
        public string Athr { get; set; }
        public void Show()
        {
            
            Author author = new Author();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(author.Athr);
        }
    }
    class Content
    {
        public string Cntnt { get; set; }
        public void Show()
        {

            Content content = new Content();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(content.Cntnt);

        }
    }
    class Book
    {
        public void Show()
        {

            Title title = new Title();
            Content content = new Content();
            Author author = new Author();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Insert Title: ");
            title.Ttl = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Insert Author: ");
            author.Athr = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Insert Content: ");
            content.Cntnt = Console.ReadLine();

            author.Show();
            title.Show();
            content.Show();
        }
    }
}
