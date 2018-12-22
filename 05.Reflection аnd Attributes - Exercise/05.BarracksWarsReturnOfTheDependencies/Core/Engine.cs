namespace BarrackWarsTheCommandsStrikeBack.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

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
            IExecutable command = (IExecutable)Activator.CreateInstance(typeOfCommand, new object[] { data });

            IEnumerable<FieldInfo> fieldsToInject = typeOfCommand
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(f => f.GetCustomAttributes(false)
                    .Any(ca => ca.GetType() == typeof(CustomAttributes.InjectAttribute)));

            foreach (var commandField in fieldsToInject)
            {
                object engineClassFieldValue = typeof(Engine)
                    .GetField(commandField.Name, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(this);

                commandField.SetValue(command, engineClassFieldValue);
            }

            string result = command.Execute();
            return result;
        }
    }
}