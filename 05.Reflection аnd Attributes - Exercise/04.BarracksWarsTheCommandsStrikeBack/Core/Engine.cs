namespace BarrackWarsTheCommandsStrikeBack.Core
{
    using System;
    using Contracts;

    public class Engine : IRunnable
    {
        private readonly IRepository repository;
        private readonly IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
        
        private string InterpredCommand(string[] data, string commandName)
        {
            commandName = commandName[0].ToString().ToUpper() + commandName.Substring(1) + "Command";
            Type typeOfCommand = Type.GetType("BarrackWarsTheCommandsStrikeBack.Core.Commands." + commandName);
            IExecutable command = (IExecutable)Activator
                .CreateInstance(typeOfCommand, new object[] { data, repository, unitFactory });

            string result = command.Execute();
            return result;
        }
    }
}