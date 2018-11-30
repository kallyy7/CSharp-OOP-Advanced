using System;

public class StartUp
{
    public static void Main()
    {
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            int integer = int.Parse(Console.ReadLine());
			
            Box<int> boxOfInteger = new Box<int>(integer);

            Console.WriteLine(boxOfInteger);
        }
    }
}

