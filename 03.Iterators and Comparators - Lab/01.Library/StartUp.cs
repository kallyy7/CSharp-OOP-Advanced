namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var library = new Library();

            while (true)
            {
                string title = Console.ReadLine();
                if (title.Equals("end"))
                {
                    break;
                }

                int year = int.Parse(Console.ReadLine());
                List<string> authorName = Console.ReadLine()
                    .Split()
                    .ToList();

                var book = new Book(title, year, authorName);

                library.Books.Add(book);               
            }

            foreach (var book in library.Books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}