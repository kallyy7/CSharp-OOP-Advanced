namespace BarrackWarsTheCommandsStrikeBack.Core.Commands
{
    using System;
    using Contracts;

    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {

        }

        public override string Execute()
        {
            var typeOfUnit = Data[1];

            try
            {
                this.Repository.RemoveUnit(typeOfUnit);
                return $"{typeOfUnit} retired!";
            }
            catch (ArgumentException argumentException)
            {
                return argumentException.Message;
            }
        }
    }
}