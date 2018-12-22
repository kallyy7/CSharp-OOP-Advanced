using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        ListyIterator<string> listyIterator = null;

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] tokens = command.Split();

            switch (tokens[0])
            {
                case "Create":
                    listyIterator = new ListyIterator<string>(tokens.Skip(1).ToArray());
                    break;
                case "Move":
                    Console.WriteLine(listyIterator.Move());
                    break;
                case "Print":
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (InvalidOperationException invalidOperationException)
                    {
                        Console.WriteLine(invalidOperationException.Message);
                    }
                    break;
                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext());
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}

