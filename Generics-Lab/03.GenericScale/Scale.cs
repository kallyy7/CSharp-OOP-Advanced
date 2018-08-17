namespace GenericScale
{
    using System;

    public class Scale<T>
        where T : IComparable<T>
    {
        private T left;
        private T right;

        public T Left
        {
            get => this.left;
            set => left = value;
        }

        public T Right
        {
            get => this.right;
            set => right = value;
        }

        public T GetHeavier()
        {
            var result = this.left.CompareTo(this.right);

            if (left.Equals(right))
            {
                return default(T);
            }
            return result > 0 ? this.left : this.right;
        }
    }
}
