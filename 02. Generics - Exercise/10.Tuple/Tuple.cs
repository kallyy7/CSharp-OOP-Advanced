public class Tuple<T1, T2>
{
    private readonly T1 tupleOne;
    private readonly T2 tupleTwo;

    public Tuple(T1 tupleOne, T2 tupleTwo)
    {
        this.tupleOne = tupleOne;
        this.tupleTwo = tupleTwo;
    }

    public override string ToString()
    {
        return $"{tupleOne} -> {tupleTwo}";
    }
}
