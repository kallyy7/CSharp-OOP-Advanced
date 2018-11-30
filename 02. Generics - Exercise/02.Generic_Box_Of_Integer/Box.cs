public class Box<T>
{
    private readonly T value;

    public Box(T value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        return $"{this.value.GetType().FullName}: {this.value}";
    }
}

