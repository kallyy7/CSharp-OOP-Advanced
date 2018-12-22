namespace BarracksWarsANewFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Type classType = Type.GetType("BarracksWarsANewFactory.Models.Units." + unitType);
            return (IUnit)Activator.CreateInstance(classType);
        }
    }
}
