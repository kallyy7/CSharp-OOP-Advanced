namespace GenericScale
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var scale = new Scale<int>();

            scale.Right = 2;
            scale.Left = 5;

            Console.WriteLine(scale.GetHeavier());           
        }
    }
}
