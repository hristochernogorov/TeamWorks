
namespace StarCraft.Engine
{
    using StarCraft.GameObject;
    using StarCraft.Interfaces;
    using StarCraft.CustomAttributes;
    [Author("Todor Dimitrov")]
    public class UnitFactory : IUnitFactory
    {
        public IFighter CreateFighterUnit(Position position, IPlayer player, int mineral, int gas, int sloat)
        {
            throw new System.NotImplementedException();
        }

        public IGatherer CreateGathererUnit(Position position, IPlayer player, int mineral, int gas, int sloat)
        {
            throw new System.NotImplementedException();
        }
    }
}
