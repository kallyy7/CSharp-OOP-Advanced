using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        List<Box<string>> boxes = new List<Box<string>>();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string strings = Console.ReadLine();
            boxes.Add(new Box<string>(strings));
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

