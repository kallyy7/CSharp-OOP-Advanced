namespace BoxOfT
{
    using System.Collections.Generic;
    using System.Linq;

    public class Box<T>
    {
        private List<T> elements;

        public Box()
        {
            this.elements = new List<T>();
        }

        public void Add(T element) => this.elements.Add(element);

        public T Remove()
        {
            var removedElement = this.elements.Last();
            this.elements.Remove(removedElement);
            return removedElement;
        }

        public int Count => this.elements.Count;
    }
}
