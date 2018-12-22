namespace BarrackWarsTheCommandsStrikeBack.Core.Commands
{
    using Contracts;
    using CustomAttributes;

    public class ReportCommand : Command
    {
        [Inject]
        private IRepository repository;

        public ReportCommand(string[] data) : base(data)
        {

        }

        public IRepository Repository
        {
            get => repository;
            set => repository = value;
        }

        public override string Execute()
        {
            string output = this.Repository.Statistics;
            return output;
        }
    }
}