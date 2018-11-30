using System;
using System.Collections.Generic;

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

        string element = Console.ReadLine();

        Console.WriteLine(CountGreater(boxes, element));
    }

    static int CountGreater<T>(IEnumerable<Box<T>> collection, T element)
        where T : IComparable<T>
    {
        int counter = 0;

        foreach (var item in collection)
        {
            if (item.CompareTo(element) > 0)
            {
                counter++;
            }
        }

        return counter;
    }
}

