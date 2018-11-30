using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        List<Box<int>> boxes = new List<Box<int>>();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            int value = int.Parse(Console.ReadLine());
            boxes.Add(new Box<int>(value));
        }

        int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int firstIndex = indices[0];
        int secondIndex = indices[1];

        Swap(boxes, firstIndex, secondIndex);

        foreach (var box in boxes)
        {
            Console.WriteLine(box);
        }
    }

    static void Swap<T>(IList<Box<T>> list, int firstIndex, int secondIndex)
    {
        Box<T> temp = list[firstIndex];
        list[firstIndex] = list[secondIndex];
        list[secondIndex] = temp;
    }
}

