using System;
namespace Book
{
    class Book
    {
        public string title;
        public string author;
        public int isbn;
        public Book(string Title , string Author , int ISBN)
        {
            title = Title;
            author = Author;
            isbn = ISBN;
        }

        public string getTitle()
        {
           Console.Write("Enter book title : ");
           string title = Console.ReadLine();
           return title;
        }
          public string getAuthor()
        {
           Console.Write("Enter Author : ");
           string author = Console.ReadLine();
           return author;
        }

         public int getIsbn()
        {
            Console.Write("Enter ISBN : ");
            int isbn = Convert.ToInt32(Console.ReadLine());
            return isbn;
        }
       
        static void Main(string[] args)
        {
            Book b = new Book("" , "" , 245656);
            Console.WriteLine("Book Title = " + b.getTitle());
            Console.WriteLine("Author = " + b.getAuthor());
            Console.WriteLine("ISBN = " + b.getIsbn());
        }
    }
}