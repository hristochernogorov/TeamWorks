
namespace StarCraft.Interfaces
{
    using StarCraft.GameObject;
    using StarCraft.CustomAttributes;
    [Author("Todor Dimitrov")]
   public interface IUnitFactory
    {
        IFighter CreateFighterUnit(Position position, string name);
        IGatherer CreateProbe(Position position, string name);
        IGatherer CreateScv(Position position, string name);
        IGatherer CreateDrone(Position position, string name);
    }
}
