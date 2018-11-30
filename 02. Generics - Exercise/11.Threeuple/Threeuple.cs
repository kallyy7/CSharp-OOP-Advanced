public class Threeuple<T1, T2, T3>
{
    private readonly T1 tupleOne;
    private readonly T2 tupleTwo;
    private readonly T3 tupleThree;

    public Threeuple(T1 tupleOne, T2 tupleTwo, T3 tupleThree)
    {
        this.tupleOne = tupleOne;
        this.tupleTwo = tupleTwo;
        this.tupleThree = tupleThree;
    }

    public override string ToString()
    {
        return $"{tupleOne} -> {tupleTwo} -> {tupleThree}";
    }
}

