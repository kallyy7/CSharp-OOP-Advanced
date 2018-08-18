namespace Attributes
{
    [SoftUni("Ventsi")]
    public class StartUp
    {
        [SoftUni("Gosho")]
        public static void Main()
        {
            var tracker = new Tracker();
            System.Console.WriteLine(tracker.PrintMethodsByAuthor());
        }
    }
}
