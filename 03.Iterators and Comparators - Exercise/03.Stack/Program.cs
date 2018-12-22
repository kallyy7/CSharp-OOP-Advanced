using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            switch (tokens[0])
            {
                case "Push":
                    int[] elements = tokens.Skip(1).Select(i => i.Split(',').First()).Select(int.Parse).ToArray();
                    stack.Push(elements);
                    break;
                case "Pop":
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException invalidOperationException)
                    {
                        Console.WriteLine(invalidOperationException.Message);
                    }
                    break;
            }
        }

        foreach (var element in stack)
        {
            Console.WriteLine(element);
        }

        foreach (var element in stack)
        {
            Console.WriteLine(element);
        }
    }
}

