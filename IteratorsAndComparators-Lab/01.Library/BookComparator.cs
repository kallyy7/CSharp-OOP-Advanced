namespace Library
{
    using System.Collections.Generic;

    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book firstBook, Book secondBook)
        {
            int result = firstBook.title.CompareTo(secondBook.title);
            if (result == 0)
            {
                result = firstBook.year.CompareTo(secondBook.year);
            }

            return result;
        }
    }
}