namespace BarrackWarsTheCommandsStrikeBack.Contracts
{
    public interface IUnitFactory
    {
        IUnit CreateUnit(string unitType);
    }
}