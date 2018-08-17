namespace Library
{
    using System;
    using System.Collections.Generic;

    public class Book : IComparable<Book>
    {
        public string title { get; private set; }

        public int year { get; private set; }

        public IReadOnlyList<string> authors { get; private set; }

        public Book(string title, int year, List<string> authors)
        {
            this.title = title;
            this.year = year;
            this.authors = authors;
        }

        public int CompareTo(Book other)
        {
            int result = this.year.CompareTo(other.year);

            if (result == 0)
            {
                result = this.title.CompareTo(other.title);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{this.title} - {this.year}";
        }
    }
}