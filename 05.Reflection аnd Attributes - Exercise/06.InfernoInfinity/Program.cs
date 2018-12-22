public class Program
{
    public static void Main()
    {
        WeaponRepository repository = new WeaponRepository();
        CommandInterpreter interpreter = new CommandInterpreter();
        WeaponFactory weaponFactory = new WeaponFactory();
        GemFactory gemFactory = new GemFactory();

        IRunnable engine = new Engine(gemFactory, weaponFactory, interpreter, repository);
        engine.Run();
    }
}

