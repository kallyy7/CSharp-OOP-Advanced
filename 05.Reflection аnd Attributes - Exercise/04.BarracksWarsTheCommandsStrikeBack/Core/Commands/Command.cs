namespace BarrackWarsTheCommandsStrikeBack.Core.Commands
{
    using Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }

        protected string[] Data
        {
            get => this.data;
            set => this.data = value;
        }

        protected IRepository Repository
        {
            get => this.repository;
            set => this.repository = value;
        }

        protected IUnitFactory UnitFactory
        {
            get => this.unitFactory;
            set => this.unitFactory = value;
        }

        public abstract string Execute();
    }
}