
namespace StarCraft.Interfaces
{
    using StarCraft.GameObject;
    using StarCraft.CustomAttributes;
    [Author("Todor Dimitrov")]
    interface IUnitFactory
    {
        IFighter CreateFighterUnit(Position position, IPlayer player, int mineral, int gas, int sloat);
        IGatherer CreateGathererUnit(Position position, IPlayer player, int mineral, int gas, int sloat);
    }
}
