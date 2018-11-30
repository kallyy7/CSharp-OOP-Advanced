using System;

public class StartUp
{
    public static void Main()
    {
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string strings = Console.ReadLine();
			
            Box<string> boxOfStrings = new Box<string>(strings);

            Console.WriteLine(boxOfStrings);
        }
    }
}

