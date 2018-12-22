namespace BarrackWarsTheCommandsStrikeBack.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Type classType = Type.GetType("BarrackWarsTheCommandsStrikeBack.Models.Units." + unitType);
            return (IUnit)Activator.CreateInstance(classType);
        }
    }
}