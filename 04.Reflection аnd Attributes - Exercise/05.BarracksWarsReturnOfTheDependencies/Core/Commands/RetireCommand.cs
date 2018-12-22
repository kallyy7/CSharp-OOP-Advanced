namespace BarrackWarsTheCommandsStrikeBack.Core.Commands
{
    using System;
    using Contracts;
    using CustomAttributes;

    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data) : base(data)
        {

        }

        public override string Execute()
        {
            string typeOfUnit = Data[1];

            try
            {
                this.repository.RemoveUnit(typeOfUnit);
                return $"{typeOfUnit} retired!";
            }
            catch (ArgumentException argumentException)
            {
                return argumentException.Message;
            }
        }
    }
}