using System;

public class StartUp
{
    public static void Main()
    {
        CustomList<string> list = new CustomList<string>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] tokens = input.Split();
            string command = tokens[0];

            switch (command)
            {
                case "Add":
                    list.Add(tokens[1]);
                    break;
                case "Remove":
                    int index = int.Parse(tokens[1]);
                    list.Remove(index);
                    break;
                case "Contains":
                    bool result = list.Contains(tokens[1]);
                    Console.WriteLine(result);
                    break;
                case "Swap":
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);
                    list.Swap(firstIndex, secondIndex);
                    break;
                case "Greater":
                    int count = list.CountGreaterThan(tokens[1]);
                    Console.WriteLine(count);
                    break;
                case "Min":
                    string minElement = list.Min();
                    Console.WriteLine(minElement);
                    break;
                case "Max":
                    string maxElement = list.Max();
                    Console.WriteLine(maxElement);
                    break;
                case "Print":
                    foreach (var element in list)
                    {
                        Console.WriteLine(element);
                    }
                    break;
            }
        }
    }
}

