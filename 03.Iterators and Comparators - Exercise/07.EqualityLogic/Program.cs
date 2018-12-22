using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        SortedSet<Person> sorted = new SortedSet<Person>();
        HashSet<Person> hash = new HashSet<Person>();

        int peopleCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < peopleCount; i++)
        {
            string[] inputArgs = Console.ReadLine().Split();
            string name = inputArgs[0];
            int age = int.Parse(inputArgs[1]);

            Person person = new Person(name, age);

            sorted.Add(person);
            hash.Add(person);
        }

        Console.WriteLine(sorted.Count);
        Console.WriteLine(hash.Count);
    }
}