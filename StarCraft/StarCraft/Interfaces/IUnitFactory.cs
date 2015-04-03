
namespace StarCraft.Interfaces
{
    using StarCraft.GameObject;
    interface IUnitFactory
    {
        IFighter CreateFighterUnit(Position position, IPlayer player, int mineral, int gas, int sloat);
        IGatherer CreateGathererUnit(Position position, IPlayer player, int mineral, int gas, int sloat);
    }
}
