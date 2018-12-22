using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<Person> peoples = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] tokens = input.Split();
            string name = tokens[0];
            int age = int.Parse(tokens[1]);
            string town = tokens[2];

            Person person = new Person(name, age, town);
            peoples.Add(person);
        }

        int personIndex = int.Parse(Console.ReadLine()) - 1;
        Person personToCompare = peoples[personIndex];

        int matches = 0;

        foreach (var person in peoples)
        {
            if (person.CompareTo(personToCompare) == 0)
            {
                matches++;
            }
        }

        if (matches > 1)
        {
            Console.WriteLine($"{matches} {peoples.Count - matches} {peoples.Count}");
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
}

