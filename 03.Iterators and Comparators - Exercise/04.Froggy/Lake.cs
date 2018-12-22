using System.Collections;
using System.Collections.Generic;

public class Lake : IEnumerable<int>
{
    private readonly int[] stones;

    public Lake(int[] stones)
    {
        this.stones = stones;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < this.stones.Length; i += 2)
        {
            yield return this.stones[i];
        }

        int lastIndex = this.stones.Length - 1;
        if (lastIndex % 2 == 0)
        {
            lastIndex--;
        }

        for (int i = lastIndex; i > 0; i -= 2)
        {
            yield return this.stones[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
}

