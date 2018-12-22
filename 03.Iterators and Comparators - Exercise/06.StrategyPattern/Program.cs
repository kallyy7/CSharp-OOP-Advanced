using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        SortedSet<Person> namePeople = new SortedSet<Person>(new PersonNameComparer());
        SortedSet<Person> agePeople = new SortedSet<Person>(new PersonAgeComparer());

        int peopleCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < peopleCount; i++)
        {
            string[] inputArgs = Console.ReadLine().Split();
            string name = inputArgs[0];
            int age = int.Parse(inputArgs[1]);

            Person person = new Person(name, age);

            namePeople.Add(person);
            agePeople.Add(person);
        }

        Console.WriteLine(string.Join(Environment.NewLine, namePeople));
        Console.WriteLine(string.Join(Environment.NewLine, agePeople));
    }
}

