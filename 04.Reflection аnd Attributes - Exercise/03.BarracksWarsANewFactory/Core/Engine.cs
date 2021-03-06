﻿namespace BarracksWarsANewFactory.Core
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
            string result = string.Empty;
            switch (commandName)
            {
                case "add":
                    result = this.AddUnitCommand(data);
                    break;
                case "report":
                    result = this.ReportCommand(data);
                    break;
                case "fight":
                    Environment.Exit(0);
                    break;
                default:
                    throw new InvalidOperationException("Invalid command!");
            }

            return result;
        }


        private string ReportCommand(string[] data)
        {
            string output = this.repository.Statistics;
            return output;
        }


        private string AddUnitCommand(string[] data)
        {
            string unitType = data[1];
            IUnit unitToAdd = this.unitFactory.CreateUnit(unitType);
            this.repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
