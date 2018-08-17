namespace Library
{
    using System.Collections;
    using System.Collections.Generic;

    public class Library : IEnumerable
    {
        private List<Book> books;

        public List<Book> Books
        {
            get => this.books;
            set => books = value;
        }

        public Library(params Book[] books)
        {
            this.books = new List<Book>();
        }

        public IEnumerator<Book> GetEnumerator() =>  new LibraryIterator(books);

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public void Dispose(){ }

            public bool MoveNext() => ++currentIndex < this.books.Count;

            public void Reset() => this.currentIndex = -1;

            public Book Current => this.books[currentIndex];

            object IEnumerator.Current => this.Current;
        }
    }
}