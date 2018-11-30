using System;

public class StartUp
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        Tuple<string, string> tupleOne = new Tuple<string, string>(input[0] + " " + input[1], input[2]);
        Console.WriteLine(tupleOne);

        input = Console.ReadLine().Split();
        Tuple<string, int> tupleTwo = new Tuple<string, int>(input[0], int.Parse(input[1]));
        Console.WriteLine(tupleTwo);

        input = Console.ReadLine().Split();
        Tuple<int, double> tupleThree = new Tuple<int, double>(int.Parse(input[0]), double.Parse(input[1]));
        Console.WriteLine(tupleThree);
    }
}

