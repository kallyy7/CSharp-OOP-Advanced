using System;

public class StartUp
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        Threeuple<string, string, string> threeupleOne = new Threeuple<string, string, string>(input[0] + " " + input[1], input[2], input[3]);
        Console.WriteLine(threeupleOne);

        input = Console.ReadLine().Split();
        bool isDrunk = input[2] == "drunk" ? true : false;
        Threeuple<string, int, bool> threeupleTwo = new Threeuple<string, int, bool>(input[0], int.Parse(input[1]), isDrunk);
        Console.WriteLine(threeupleTwo);

        input = Console.ReadLine().Split();
        Threeuple<string, double, string> threeupleThree = new Threeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]);
        Console.WriteLine(threeupleThree);
    }
}

