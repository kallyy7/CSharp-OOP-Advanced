namespace BarrackWarsTheCommandsStrikeBack.Core.Commands
{
    using Contracts;
    using CustomAttributes;

    public class AddCommand : Command
    {
        [Inject]
        private IRepository repository;

        [Inject]
        private IUnitFactory unitFactory;

        public IUnitFactory UnitFactory
        {
            get => unitFactory;
            set => unitFactory = value;
        }

        public IRepository Repository
        {
            get => repository;
            set => repository = value;
        }

        public AddCommand(string[] data) : base(data)
        {

        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
            this.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}